using System.Xml.Serialization;

namespace ToolsCore.XML;

/// <summary>
///     Trieda definujuca farby a pisma pre viacere prvky programu
/// </summary>
public class Style
{
    /// <summary>
    ///     Ci ovladacie prvky v GUI pouzivaju predvoleny vzhlad.
    /// </summary>
    [XmlElement("DefaultStyle"), DefaultValue(true)] 
    public bool ControlsDefaultStyle { get; set; }

    /// <summary>
    ///     Ci okna v GUI maju mat tmavy TitleBar (funguje len vo Windows 10).
    /// </summary>
    [XmlElement("DarkTitlebar"), DefaultValue(false)] 
    public bool DarkTitleBar { get; set; }

    /// <summary>
    ///     Ci ovladacie prvky v GUI maju mat tmavy ScrollBar (funguje len vo Windows 10).
    /// </summary>
    [XmlElement("DarkScrollBar"), DefaultValue(false)]
    public bool DarkScrollBar { get; set; }

    /// <summary>
    ///     Farebna schema pre ovladacie prvky v GUI
    /// </summary>
    [XmlElement("ControlsColorScheme")] 
    public ControlsColorScheme ControlsColorScheme { get; set; } = new();

    /// <summary>
    ///     Nazov stylu
    /// </summary>
    [XmlAttribute("name")] 
    public string Name { get; set; }

    /// <summary>
    ///     Vyvori novu instanciu triedy <see cref="Style"/>.
    /// </summary>
    public Style()
    {
        ControlsDefaultStyle = true;
        DarkScrollBar = false;
        DarkTitleBar = false;
    }

    public Style(Style original)
    {
        ControlsDefaultStyle = original.ControlsDefaultStyle;
        DarkScrollBar = original.DarkScrollBar;
        DarkTitleBar = original.DarkTitleBar;
        Name = original.Name;
        ControlsColorScheme = original.ControlsColorScheme;
    }

    /// <summary>Returns a string that represents the current object.</summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() => Name;

    /// <summary>
    ///     Nastavi nastavenia farieb pre ovladacie prvky na predvolene hodnoty pre tmavy rezim
    /// </summary>
    public static ControlsColorScheme SetDefaultDarkControlsScheme()
    {
        var scheme = new ControlsColorScheme
        {
            Panel = new ColorSetting { BackColor = Color.FromArgb(30, 30, 30), ForeColor = Color.White, DisableFontEdit = true },
            Button = new ColorSetting { BackColor = Color.FromArgb(51, 51, 55), ForeColor = Color.White, DisableFontEdit = true },
            Label = new ColorSetting { BackColor = Color.FromArgb(51, 51, 55), ForeColor = Color.White, DisableFontEdit = true },
            Box = new ColorSetting { BackColor = Color.FromArgb(37, 37, 38), ForeColor = Color.White, DisableFontEdit = true },
            Border = new ColorSetting { ForeColor = Color.FromArgb(62, 62, 66), DisableFontEdit = true, DisableBackColorEdit = true },
            Mark = new ColorSetting { ForeColor = Color.FromArgb(165, 165, 165), DisableFontEdit = true, DisableBackColorEdit = true },
            Highlight = new ColorSetting { BackColor = Color.FromArgb(0, 120, 215), ForeColor = Color.White, DisableFontEdit = true }
        };

        return scheme;
    }

    [XmlIgnore]
    public static Style DefaultLightStyle
    {
        get
        {
            var style = new Style
            {
                Name = StyleNames.LIGHT
            };

            return style;
        }
    }

    [XmlIgnore]
    public static Style DefaultDarkStyle
    {
        get
        {
            var style = DefaultLightStyle;
            style.Name = StyleNames.DARK;
            style.ControlsColorScheme = SetDefaultDarkControlsScheme();
            style.ControlsDefaultStyle = false;
            style.DarkScrollBar = true;
            style.DarkTitleBar = true;
            return style;
        }
    }
}