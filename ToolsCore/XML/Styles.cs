using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ToolsCore.Tools;

namespace ToolsCore.XML
{
    /// <summary>
    ///     Trieda reprezentujuca zoznam stylov definovanych pre GUI programu
    /// </summary>
    [XmlRoot("STYLES")]
    public class Styles<T> where T : Style, new()
    {
        /// <summary>
        ///     Aktualne pouzivany styl v programe
        /// </summary>
        [XmlElement("using")] 
        [DefaultValue(0)]
        public int UsingStyleID;

        /// <summary>
        ///     Zoznam vsetkych stylov s vlastnostami
        /// </summary>
        [XmlElement("styles")] 
        public List<T> StyleList;

        /// <summary>
        ///     Konstruktor
        /// </summary>
        public Styles()
        {
            StyleList = new List<T>();
            UsingStyleID = 0;
        }

        /// <summary>
        ///     Indexer pre jednoduchsi vyber z listu stylov
        /// </summary>
        /// <param name="index">index prvku</param>
        public T this[int index]
        {
            get => StyleList[index];
            set => StyleList[index] = value;
        }

        /// <summary>
        ///     Indexer pre jednoduchsi vyber z listu stylov. Vrati styl podla nazvu stylu
        /// </summary>
        /// <param name="index"></param>
        public Style this[string index] => StyleList.First(i => i.Name == index);

        /// <summary>
        ///     Vrati pocet stylov v zozname
        /// </summary>
        public int Count => StyleList.Count;

        /// <summary>
        ///     Prida styl do zoznamu stylov
        /// </summary>
        /// <param name="style"></param>
        public void Add(T style)
        {
            StyleList.Add(style);
        }

        /// <summary>
        ///     Nacitava data z konfiguracneho suboru
        /// </summary>
        /// <param name="fileName">cesta k suboru</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Ak konfiguacny subor obsahoval nelatnu hodnotu</exception>
        public static Styles<T> ReadData(string fileName)
        {
            Styles<T> styles = null;
            try
            {
                var text = File.ReadAllText(fileName, Encodings.Win1250);
                if (!string.IsNullOrEmpty(text))
                {
                    styles = (Styles<T>)XMLSerialization.Deserialize(text, typeof(Styles<T>));

                    var ids = new List<string>(styles.StyleList.Count);
                    ids.AddRange(styles.StyleList.Select(style => style.Name));

                    var query = ids.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();

                    if (query.Count != 0)
                    {
                        var error = $"Chyba v súbore štýlov: Štýl {query[0]} je zadefinovaný viackrát.";
                        Log.Error(error);
                        throw new ArgumentException(error);
                    }

                    var rewrite = false;

                    if (!ids.Contains(StyleNames.LIGHT))
                    {
                        styles.StyleList.Insert(0, GetDefaultStyle(false));
                        rewrite = true;
                    }

                    if (!ids.Contains(StyleNames.DARK))
                    {
                        styles.StyleList.Insert(1, GetDefaultStyle(true));
                        rewrite = true;
                    }

                    if (rewrite) 
                        WriteData(fileName, styles);

                    if (styles.UsingStyleID < 0 || styles.UsingStyleID > styles.StyleList.Count - 1)
                    {
                        var error =
                            $"Chyba v súbore štýlov: Nastavenie {nameof(UsingStyleID)} obsahuje nesprávnu hodnotu {styles.UsingStyleID}.";
                        Log.Error(error);
                        throw new ArgumentException(error);
                    }
                }
            }
            catch (FileNotFoundException)
            {
            }

            if (styles == null)
            {
                styles = new Styles<T>();

                styles.StyleList.Insert(0, GetDefaultStyle(false));
                styles.StyleList.Insert(1, GetDefaultStyle(true));
                WriteData(fileName, styles);
            }

            return styles;
        }

        /// <summary>
        ///     Zapise data do konfiguracneho suboru
        /// </summary>
        /// <param name="fileName">cesta k suboru</param>
        /// <param name="obj">data</param>
        public static void WriteData(string fileName, object obj)
        {
            XMLSerialization.SerializeToFile(fileName, RuntimeHelpers.GetObjectValue(obj));
        }

        private static T GetDefaultStyle(bool dark)
        {
            var type = typeof(T);
            var property = type.GetProperty(dark ? nameof(Style.DefaultDarkStyle) : nameof(Style.DefaultLightStyle),
                BindingFlags.Public | BindingFlags.Static);
            return property?.GetValue(null) as T;
        }
    }
}