using System.Xml.Serialization;

namespace ToolsCore.XML;

/// <summary>
///     Trieda definujuca farby pre ovladacie prvky GUI.
/// </summary>
public class ControlsColorScheme
{
    /// <summary>
    ///     Styl pre tlacidla.
    /// </summary>
    [XmlElement("Button")] 
    public ColorSetting Button = new(SystemColors.ButtonFace, SystemColors.ControlText, true);

    /// <summary>
    ///     Styl pre všetky štítky.
    /// </summary>
    [XmlElement("Label")] 
    public ColorSetting Label = new(SystemColors.Control, SystemColors.ControlText, true);

    /// <summary>
    ///     Styl pre boxy - ComboBox, ListBox....
    /// </summary>
    [XmlElement("Box")] 
    public ColorSetting Box = new(SystemColors.ControlLightLight, SystemColors.ControlText, true);

    /// <summary>
    ///     Farba okrajov ovladacich prvkov (nastavovat iba ForeColor).
    /// </summary>
    [XmlElement("Border")] 
    public ColorSetting Border = new(SystemColors.WindowFrame, true);

    /// <summary>
    ///     Styl panelu.
    /// </summary>
    [XmlElement("Panel")] 
    public ColorSetting Panel = new(SystemColors.Control, SystemColors.ControlText, true);

    /// <summary>
    ///     Farba značiek - pouzite ako značka vo vnutri RadioButton a CheckBox (nastavovat iba ForeColor).
    /// </summary>
    [XmlElement("Mark")] 
    public ColorSetting Mark = new(SystemColors.ControlText, true);

    /// <summary>
    ///     Styl pre oznacenie prave aktivneho ovladacieho prvku resp. jeho casti.
    /// </summary>
    [XmlElement("Highlight")]
    public ColorSetting Highlight = new(SystemColors.Highlight, SystemColors.ControlText, true);
}