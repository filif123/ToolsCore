using System.ComponentModel;
using System.Xml.Serialization;

namespace ToolsCore.XML
{
    /// <summary>
    ///     Konfiguracny subor
    /// </summary>
    [XmlRoot("CONFIG")]
    public abstract class Config
    {
        /// <summary>
        ///     Jazyk aplikacie
        /// </summary>
        public enum AppLanguage
        {
            /// <summary>
            ///     Slovencina
            /// </summary>
            [XmlEnum(Name = "SK")] SK,

            /// <summary>
            ///     Cestina
            /// </summary>
            [XmlEnum(Name = "CZ")] CZ
        }

        /// <summary>
        ///     Typ debuggovania
        /// </summary>
        public enum DebugMode
        {
            /// <summary>
            ///     Normalne chybove hlasky
            /// </summary>
            [XmlEnum(Name = "0")] ONLY_MESSAGE,

            /// <summary>
            ///     Zobrazovanie detailnejsich chyb. hlasok
            /// </summary>
            [XmlEnum(Name = "1")] DETAILED_INFO,

            /// <summary>
            ///     Bez chybovych hlasok (spadnutie programu)
            /// </summary>
            [XmlEnum(Name = "2")] APP_CRASH
        }

        /// <summary>
        ///     Typ zobrazenia MenuStrip alebo ToolStrip na pracovnej ploche programu
        /// </summary>
        public enum DesktopMenu
        {
            /// <summary>
            ///     ToolStrip aj MenuStrip
            /// </summary>
            [XmlEnum(Name = "0")] TS_MS,

            /// <summary>
            ///     Len ToolStrip
            /// </summary>
            [XmlEnum(Name = "1")] TS_ONLY,

            /// <summary>
            ///     Len MenuStrip
            /// </summary>
            [XmlEnum(Name = "2")] MS_ONLY
        }

        /// <summary>
        ///     Mod zobrazovania chybovych hlasok v GUI
        /// </summary>
        [XmlElement("DebugModeGUI")] public DebugMode DebugModeGUI = DebugMode.ONLY_MESSAGE;

        /// <summary>
        ///     Zobrazenie menu v FMain
        /// </summary>
        [XmlElement("DesktopMenu")] public DesktopMenu DesktopMenuMode = DesktopMenu.TS_MS;

        /// <summary>
        ///     Pouzivat klasicky dizajn komponetov v GUI
        /// </summary>
        [XmlElement("ClassicGUI")] [DefaultValue(false)]
        public bool ClassicGUI;

        /// <summary>
        ///     Nastavi jazyk pouzivatelskeho rozhrania (GUI)
        /// </summary>
        [XmlElement("Language")] public AppLanguage Language = AppLanguage.SK;

        /// <summary>
        ///     Nastavi jazyk generovania datumovych obmedzeni
        /// </summary>
        [XmlElement("DateRemLocate")] public AppLanguage DateRemLocate = AppLanguage.SK;


        /// <summary>
        ///     True ak logovat informacie o aplikacii, inak False
        /// </summary>
        [XmlElement("LoggingInfo")] [DefaultValue(true)]
        public bool LoggingInfo = true;

        /// <summary>
        ///     Povolit alebo zakazat viacero instancii tohto programu
        /// </summary>
        [XmlElement("MoreInstances")] [DefaultValue(false)]
        public bool MoreInstance;

        /// <summary>
        ///     Ci sa ma prisposobit posledny stlpec v tabulke na pracovnej ploche programu
        /// </summary>
        [XmlElement("FitLastColumn")] [DefaultValue(true)]
        public bool FitLastColumn = true;


        /// <summary>
        ///     Nastavenia pisiem pre jednotlive komponenty GUI
        /// </summary>
        [XmlElement("ControlFonts")] public ControlFonts Fonts = new();


        /// <summary>
        ///     Ci sa ma zobrazovat stavovy riadok na pracovnej ploche programu
        /// </summary>
        [XmlElement("ShowStateRow")] [DefaultValue(true)]
        public bool ShowStateRow = true;

        /// <summary>
        ///     Ci sa maju zobrazovat hlavicky riadkov v tabulke na pracovnej ploche programu
        /// </summary>
        [XmlElement("ShowRowsHeader")] [DefaultValue(true)]
        public bool ShowRowsHeader = true;

        /// <summary>
        ///     True ak logovat chyby a vynimky, inak False
        /// </summary>
        [XmlElement("LoggingError")] [DefaultValue(true)]
        public bool LoggingError = true;
    }
}