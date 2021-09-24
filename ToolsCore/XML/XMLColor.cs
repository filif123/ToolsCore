using System;
using System.Drawing;
using System.Globalization;
using System.Xml.Serialization;

namespace ToolsCore.XML
{
    /// <summary>
    ///     Rozšírenie štruktúry <see cref="Color" /> o to, aby bola serializovateľná do XML.
    /// </summary>
    public struct XMLColor
    {
        private Color _color;

        /// <summary>
        ///     Konstruktor
        /// </summary>
        /// <param name="c"></param>
        public XMLColor(Color c)
        {
            _color = c;
        }

        /// <summary>
        ///     Farba ako text pre XML
        /// </summary>
        [XmlText]
        public string Default
        {
            get => FromColor(_color);
            set => _color = ToColor(value);
        }


        /// <summary>
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static implicit operator Color(XMLColor x)
        {
            return x._color;
        }

        /// <summary>
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static implicit operator XMLColor(Color c)
        {
            return new XMLColor(c);
        }

        /// <summary>
        ///     Vygeneruje reťazec (string) podľa objektu typu Color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string FromColor(Color color)
        {
            if (color.IsNamedColor)
                return color.Name;

            var colorValue = color.ToArgb();

            return (uint)colorValue >> 24 == 0xFF ? $"#{colorValue & 0x00FFFFFF:X6}" : $"#{colorValue:X8}";
        }

        /// <summary>
        ///     Konvertuje string na object Color
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Color ToColor(string value)
        {
            try
            {
                if (value[0] == '#')
                {
                    var argb = (value.Length <= 7 ? unchecked((int)0xFF000000) : 0) + int.Parse(value.Substring(1), NumberStyles.HexNumber);
                    return Color.FromArgb(argb);
                }

                return Color.FromName(value);
            }
            catch (Exception)
            {
                return Color.Empty;
            }
        }
    }
}