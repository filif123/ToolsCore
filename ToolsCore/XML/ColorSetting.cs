using System.ComponentModel;
using System.Drawing;
using System.Xml.Serialization;

namespace ToolsCore.XML
{
    /// <summary>
    ///     Trieda reprezentujúca nastavenia farieb a písma pre GUI.
    /// </summary>
    public class ColorSetting
    {
        /// <summary>
        ///     Vytvori novu instanciu triedy <see cref="ColorSetting"/>.
        /// </summary>
        public ColorSetting()
        {
        }

        /// <summary>
        ///     Vytvori novu instanciu triedy <see cref="ColorSetting"/> so zadafinovanymi farbami pozadia, popredia
        ///     a ci sa bude dat menit pismo pre dane nastavenie v GUI.
        /// </summary>
        public ColorSetting(Color backColor, Color foreColor, bool disableFontEdit = false)
        {
            BackColor = backColor;
            ForeColor = foreColor;
            DisableFontEdit = disableFontEdit;
        }

        /// <summary>
        ///     Vytvori novu instanciu triedy <see cref="ColorSetting"/> so zadafinovanymi farbami popredia
        ///     a ci sa bude dat menit pismo pre dane nastavenie v GUI.
        /// </summary>
        public ColorSetting(Color foreColor, bool disableFontEdit = false)
        {
            ForeColor = foreColor;
            DisableFontEdit = disableFontEdit;
            DisableBackColorEdit = true;
        }

        /// <summary>
        ///     Farba pozadia.
        /// </summary>
        [XmlIgnore] 
        public Color BackColor;

        /// <summary>
        ///     Použiť hrubý rez písma.
        /// </summary>
        [XmlAttribute("bold")] 
        public bool Bold;

        /// <summary>
        ///     Nastavi, aby pouzivatel nemohol menit farbu pozadia - BackColor.
        /// </summary>
        [XmlIgnore] 
        public bool DisableBackColorEdit;

        /// <summary>
        ///     Nastavi, aby pouzivatel nemohol menit pismo.
        /// </summary>
        [XmlIgnore] 
        public bool DisableFontEdit;

        /// <summary>
        ///     Farba popredia.
        /// </summary>
        [XmlIgnore] 
        public Color ForeColor;

        /// <summary>
        ///     Názov nastavenia, ktoré sa bude zobrazovať v GUI.
        ///     Lokalizovateľná
        /// </summary>
        [XmlIgnore, Localizable(true)]  
        public string Name;

        /// <summary>
        ///     Farba pozadia vo formáte XML atribútu.
        /// </summary>
        [XmlAttribute("b"), DefaultValue("#00000000")]
        public string ColorBackAttr
        {
            get => XMLColor.FromColor(BackColor);
            set => BackColor = XMLColor.ToColor(value);
        }

        /// <summary>
        ///     Farba popredia vo formáte XML atribútu.
        /// </summary>
        [XmlAttribute("f")]
        public string ColorForeAttr
        {
            get => XMLColor.FromColor(ForeColor);
            set => ForeColor = XMLColor.ToColor(value);
        }

        /// <inheritdoc />
        public override string ToString() => Name;

        /// <summary>
        ///     Skopíruje nastavenie.
        /// </summary>
        /// <param name="obj">Pôvodné nastavenie.</param>
        /// <returns></returns>
        public static ColorSetting Copy(ColorSetting obj)
        {
            return new ColorSetting
            {
                BackColor = obj.BackColor,
                ForeColor = obj.ForeColor,
                DisableBackColorEdit = obj.DisableBackColorEdit,
                DisableFontEdit = obj.DisableFontEdit,
                Bold = obj.Bold,
                ColorBackAttr = obj.ColorBackAttr,
                ColorForeAttr = obj.ColorForeAttr,
                Name = obj.Name
            };
        }
    }
}