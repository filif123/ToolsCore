using System.Xml.Serialization;

namespace ToolsCore.XML;

/// <summary>
///     Trieda reprezentujuca strukturu pre konfiguracny subor vo formate .XML.
/// </summary>
[XmlRoot("CONFIG")]
public abstract class Config
{
    /// <summary>
    ///     Jazyk aplikacie.
    /// </summary>
    public enum AppLanguage
    {
        /// <summary>
        ///     Slovencina.
        /// </summary>
        [XmlEnum(Name = "SK")] 
        Slovak,

        /// <summary>
        ///     Cestina.
        /// </summary>
        [XmlEnum(Name = "CZ")] 
        Czech
    }

    /// <summary>
    ///     Typ debuggovania.
    /// </summary>
    public enum DebugMode
    {
        /// <summary>
        ///     Normalne chybove hlasky.
        /// </summary>
        [XmlEnum(Name = "0")] 
        OnlyMessage,

        /// <summary>
        ///     Zobrazovanie detailnejsich chyb. hlasok.
        /// </summary>
        [XmlEnum(Name = "1")] 
        DetailedInfo,

        /// <summary>
        ///     Bez chybovych hlasok (spadnutie programu).
        /// </summary>
        [XmlEnum(Name = "2")] 
        AppCrash
    }

    /// <summary>
    ///     Typ zobrazenia MenuStrip alebo ToolStrip na pracovnej ploche programu.
    /// </summary>
    public enum DesktopMenu
    {
        /// <summary>
        ///     ToolStrip aj MenuStrip.
        /// </summary>
        [XmlEnum(Name = "0")] 
        MsTs,

        /// <summary>
        ///     Len ToolStrip.
        /// </summary>
        [XmlEnum(Name = "1")] 
        TsOnly,

        /// <summary>
        ///     Len MenuStrip.
        /// </summary>
        [XmlEnum(Name = "2")] 
        MsOnly
    }

    /// <summary>
    ///     Mod zobrazovania chybovych hlasok v GUI.
    /// </summary>
    [XmlElement("DebugModeGUI")] 
    [Description("Mod zobrazovania chybovych hlasok v GUI.")]
    public DebugMode DebugModeGUI { get; set; } = DebugMode.OnlyMessage;

    /// <summary>
    ///     Zobrazenie menu v hlavnom dialogu programu.
    /// </summary>
    [XmlElement("DesktopMenu")] 
    [Description("Zobrazenie menu v hlavnom dialogu programu.")]
    public DesktopMenu DesktopMenuMode { get; set; } = DesktopMenu.MsTs;

    /// <summary>
    ///     Pouzivat klasicky dizajn komponetov v GUI.
    /// </summary>
    [XmlElement("ClassicGUI"), DefaultValue(false)]
    [Description("Pouzivat klasicky dizajn komponetov v GUI.")]
    public bool ClassicGUI { get; set; }

    /// <summary>
    ///     Nastavi jazyk pouzivatelskeho rozhrania (GUI).
    /// </summary>
    [XmlElement("Language"), DefaultValue(0)] 
    [Description("Nastavi jazyk pouzivatelskeho rozhrania (GUI).")]
    public AppLanguage Language { get; set; } = AppLanguage.Slovak;

    /// <summary>
    ///     Nastavi jazyk generovania datumovych obmedzeni.
    /// </summary>
    [XmlElement("DateRemLocate"), DefaultValue(0)] 
    [Description("Nastavi jazyk generovania datumovych obmedzeni.")]
    public AppLanguage DateRemLocate { get; set; } = AppLanguage.Slovak;

    /// <summary>
    ///     Povolit alebo zakazat viacero instancii tohto programu.
    /// </summary>
    [XmlElement("MoreInstances"), DefaultValue(false)]
    [Description("Povolit alebo zakazat viacero instancii tohto programu.")]
    public bool MoreInstance { get; set; }

    /// <summary>
    ///     Ci sa ma prisposobit posledny stlpec v tabulke na pracovnej ploche programu.
    /// </summary>
    [XmlElement("FitLastColumn"), DefaultValue(true)]
    [Description("Ci sa ma prisposobit posledny stlpec v tabulke na pracovnej ploche programu.")]
    public bool FitLastColumn { get; set; } = true;

    /// <summary>
    ///     Nastavenia pisiem pre jednotlive komponenty GUI.
    /// </summary>
    [XmlElement("ControlFonts"), TypeConverter(typeof(ExpandableObjectConverter))] 
    [Description("Nastavenia pisiem pre jednotlive komponenty GUI.")]
    public ControlFonts Fonts { get; set; } = new();

    /// <summary>
    ///     Ci sa ma zobrazovat stavovy riadok na pracovnej ploche programu.
    /// </summary>
    [XmlElement("ShowStateRow"), DefaultValue(true)]
    [Description("Ci sa ma zobrazovat stavovy riadok na pracovnej ploche programu.")]
    public bool ShowStateRow { get; set; } = true;

    /// <summary>
    ///     Vrati alebo nastavi, ci sa maju zobrazovat hlavicky riadkov v tabulke na pracovnej ploche programu.
    /// </summary>
    [XmlElement("ShowRowsHeader"), DefaultValue(true)]
    [Description("Vrati alebo nastavi, ci sa maju zobrazovat hlavicky riadkov v tabulke na pracovnej ploche programu.")]
    public bool ShowRowsHeader { get; set; } = true;

    /// <summary>
    ///      Vrati alebo nastavi ci sa maju logovat informacie a oznamy.
    ///     <see langword="true"/> ak logovat informacie o aplikacii, inak <see langword="false"/>.
    /// </summary>
    [XmlElement("LoggingInfo"), DefaultValue(true)]
    [Description("Vrati alebo nastavi ci sa maju logovat informacie a oznamy.")]
    public bool LoggingInfo { get; set; } = true;

    /// <summary>
    ///     Vrati alebo nastavi ci sa maju logovat chyby.
    ///     <see langword="true"/> ak logovat chyby a vynimky, inak <see langword="false"/>.
    /// </summary>
    [XmlElement("LoggingError"), DefaultValue(true)]
    [Description("Vrati alebo nastavi ci sa maju logovat chyby.")]
    public bool LoggingError { get; set; } = true;
}