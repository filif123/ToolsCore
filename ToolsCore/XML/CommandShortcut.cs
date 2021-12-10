using System.Xml.Serialization;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace ToolsCore.XML;

/// <summary>
///     Reprezentuje klavesovu skratku pouzivanu na hlavnej pracovnej ploche programu.
/// </summary>
public class CommandShortcut
{
    /// <summary>
    ///     Vytvori novu instanciu triedy <see cref="CommandShortcut"/>.
    /// </summary>
    public CommandShortcut()
    {
    }

    /// <summary>
    ///     Vytvori novu instanciu triedy <see cref="CommandShortcut"/> podla struktury <see cref="ShortcutName"/>.
    /// </summary>
    /// <param name="shortcut"></param>
    public CommandShortcut(ShortcutName shortcut)
    {
        Shortcut = shortcut;
    }

    /// <summary>
    ///     Názov použitia klávesovej skratky.
    /// </summary>
    [XmlIgnore]
    public string Name { get; set; }

    /// <summary>
    ///     Klávesová skratka ako štruktúra <see cref="ShortcutName"/>.
    /// </summary>
    [XmlIgnore]
    public ShortcutName Shortcut { get; set; }

    /// <summary>
    ///     XML reprezentácia klávesovej skratky.
    /// </summary>
    [XmlAttribute("sc")]
    public string ShortcutXML
    {
        get => XMLEnum<Shortcut>.EnumToString(Shortcut.ThisShortcut);
        set => Shortcut = new ShortcutName(XMLEnum<Shortcut>.StringToEnum(value));
    }
}

/// <summary>
///     Štruktúra <see cref="Shortcut" /> pridaná o predefinovanie metódy <see cref="ToString" />, ktorá vracia
///     reprezentáciu klávesovej skratky vo formáte: X+Y.
///     Ak je <see cref="ThisShortcut" /> <see cref="Shortcut.None" />, vráti "(Žiadna)".
/// </summary>
public readonly struct ShortcutName
{
    /// <summary>
    ///     Klávesová skratka ako štruktúra.
    /// </summary>
    public readonly Shortcut ThisShortcut;

    /// <summary>
    ///     Vytvori novu instanciu struktury <see cref="ShortcutName"/> podla enumeracie <see cref="Shortcut"/>.
    /// </summary>
    /// <param name="shortcut"></param>
    public ShortcutName(Shortcut shortcut)
    {
        ThisShortcut = shortcut;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        if (ThisShortcut == Shortcut.None) 
            return "(Žiadna)";
        return new KeysConverter().ConvertToString((Keys)ThisShortcut) ?? "";
    }
}