using System.Xml.Serialization;

namespace ToolsCore.XML;

/// <summary>
///     Obsahuje zoznam všetkých nastaviteľných komponentov, pre ktoré sa nastavuje ich písmo.
/// </summary>
public class ControlFonts
{
    /// <summary>
    ///     Nastavenie písma pre Labels.
    /// </summary>
    [XmlElement("Labels")] 
    public AppFont Labels { get; set; } = new() { Font = SystemFonts.DefaultFont };

    /// <summary>
    ///     Nastavenie písma pre Buttons.
    /// </summary>
    [XmlElement("Buttons")] 
    public AppFont Buttons { get; set; } = new() { Font = SystemFonts.DefaultFont };

    /// <summary>
    ///     Nastavenie písma pre Menu.
    /// </summary>
    [XmlElement("Menu")] 
    public AppFont Menu { get; set; } = new() { Font = SystemFonts.MenuFont };

    /// <summary>
    ///     Nastavenie písma pre hlavičku śtĺpcov v DataGridView.
    /// </summary>
    [XmlElement("ColsHeaders")] 
    public AppFont ColsHeader { get; set; } = new() { Font = SystemFonts.MenuFont };

    /// <summary>
    ///     Nastavenie písma pre obsah v DataGridView.
    /// </summary>
    [XmlElement("TableCells")] 
    public AppFont TableCells { get; set; } = new() { Font = SystemFonts.DefaultFont };

    /// <summary>
    ///     Nastavenie písma pre stavový riadok v dolnej časti pracovnej plochy programu.
    /// </summary>
    [XmlElement("StateRow")] 
    public AppFont StateRow { get; set; } = new() { Font = new Font(SystemFonts.MenuFont.FontFamily, 10, FontStyle.Bold) };

    /// <summary>
    ///     Vráti zoznam všetkých nastaviteľných komponentov, pre ktoré sa nastavuje ich písmo.
    /// </summary>
    /// <returns>zoznam komponentov.</returns>
    public List<AppFont> GetValues() => new() { Labels, Buttons, Menu, ColsHeader, TableCells, StateRow };

    /// <inheritdoc />
    public override string ToString() => "(Kolekcia)";
}