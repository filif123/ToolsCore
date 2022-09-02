using System.Xml.Serialization;

namespace ToolsCore.XML;

/// <summary>
///     Trieda definujuca farby pre ovladacie prvky GUI.
/// </summary>
public record ControlsColorScheme() : IColorScheme
{
    /// <inheritdoc />
    [XmlIgnore] 
    public bool DisableFontEdit => true;

    /// <inheritdoc />
    [XmlIgnore] 
    public Font Font { get; set; } = null;

    /// <inheritdoc />
    [XmlIgnore] 
    public string Name => "Ovládacie prvky";

    [XmlIgnore]
    private static readonly Dictionary<string, ColorSetting> props = new()
    {
        [nameof(Button)] = new(SystemColors.ButtonFace, SystemColors.ControlText, true) {Name = GlobalResources.NameColorSettings_Button},
        [nameof(Label)] = new(SystemColors.Control, SystemColors.ControlText, true) { Name = GlobalResources.NameColorSettings_Label },
        [nameof(Box)] = new(SystemColors.Control, SystemColors.ControlText, true) { Name = GlobalResources.NameColorSettings_Box },
        [nameof(Border)] = new(SystemColors.WindowFrame, true) { Name = GlobalResources.NameColorSettings_Border },
        [nameof(Panel)] = new(SystemColors.Control, SystemColors.ControlText, true) { Name = GlobalResources.NameColorSettings_Panel },
        [nameof(Mark)] = new(SystemColors.ControlText, true) { Name = GlobalResources.NameColorSettings_Mark },
        [nameof(Highlight)] = new(SystemColors.Highlight, SystemColors.ControlText, true) { Name = GlobalResources.NameColorSettings_Highlight },
    };

    #region Fields

    private ColorSetting _button = InitProperty(nameof(Button));
    private ColorSetting _label = InitProperty(nameof(Label));
    private ColorSetting _box = InitProperty(nameof(Box));
    private ColorSetting _border = InitProperty(nameof(Border));
    private ColorSetting _panel = InitProperty(nameof(Panel));
    private ColorSetting _mark = InitProperty(nameof(Mark));
    private ColorSetting _highlight = InitProperty(nameof(Highlight));

    #endregion
    
    #region Properties

    /// <summary>
    ///     Styl pre tlacidla.
    /// </summary>
    [XmlElement("Button")]
    public ColorSetting Button
    {
        get => _button ??= InitProperty(nameof(Button));
        set
        {
            _button = value;
            AssignProperty(ref _button, nameof(Button));
        }
    }

    /// <summary>
    ///     Styl pre všetky štítky.
    /// </summary>
    [XmlElement("Label")]
    public ColorSetting Label
    {
        get => _label ??= InitProperty(nameof(Label));
        set
        {
            _label = value;
            AssignProperty(ref _label, nameof(Label));
        }
    }

    /// <summary>
    ///     Styl pre boxy - ComboBox, ListBox....
    /// </summary>
    [XmlElement("Box")]
    public ColorSetting Box
    {
        get => _box ??= InitProperty(nameof(Box));
        set
        {
            _box = value;
            AssignProperty(ref _box, nameof(Box));
        }
    }

    /// <summary>
    ///     Farba okrajov ovladacich prvkov (nastavovat iba ForeColor).
    /// </summary>
    [XmlElement("Border")]
    public ColorSetting Border
    {
        get => _border ??= InitProperty(nameof(Border));
        set
        {
            _border = value;
            AssignProperty(ref _border, nameof(Border));
        }
    }

    /// <summary>
    ///     Styl panelu.
    /// </summary>
    [XmlElement("Panel")]
    public ColorSetting Panel
    {
        get => _panel ??= InitProperty(nameof(Panel));
        set
        {
            _panel = value;
            AssignProperty(ref _panel, nameof(Panel));
        }
    }

    /// <summary>
    ///     Farba značiek - pouzite ako značka vo vnutri RadioButton a CheckBox (nastavovat iba ForeColor).
    /// </summary>
    [XmlElement("Mark")]
    public ColorSetting Mark
    {
        get => _mark ??= InitProperty(nameof(Mark));
        set
        {
            _mark = value;
            AssignProperty(ref _mark, nameof(Mark));
        }
    }

    /// <summary>
    ///     Styl pre oznacenie prave aktivneho ovladacieho prvku resp. jeho casti.
    /// </summary>
    [XmlElement("Highlight")]
    public ColorSetting Highlight
    {
        get => _highlight ??= InitProperty(nameof(Highlight));
        set
        {
            _highlight = value;
            AssignProperty(ref _highlight, nameof(Highlight));
        }
    }

    private static ColorSetting InitProperty(string propname) => props[propname] with { };

    private static void AssignProperty(ref ColorSetting prop, string propname)
    {
        if (prop is null)
            InitProperty(propname);
        else
        {
            prop.Name = props[propname].Name;
            prop.DisableBackColorEdit = props[propname].DisableBackColorEdit;
            prop.DisableFontBoldEdit = props[propname].DisableFontBoldEdit;
        }
    }

    protected ControlsColorScheme(ControlsColorScheme original)
    {
        Button = original.Button with { };
        Label = original.Label with { };
        Box = original.Box with { };
        Border = original.Border with { };
        Panel = original.Panel with { };
        Mark = original.Mark with { };
        Highlight = original.Highlight with { };
    }

    #endregion
}