using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ToolsCore.XML
{
    public static class XMLSerialization
    {
        private const string constXMLRedundant =
            " xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"";

        private const string constXMLNS1 = "xsi:";
        private const string constXMLNS2 = "xsd:";

        /// <summary>
        ///     Nacitava data z XML suboru
        /// </summary>
        /// <param name="file">cesta k suboru</param>
        /// <returns></returns>
        public static T ReadData<T>(string file) where T : new()
        {
            var config = default(T);
            try
            {
                var text = File.ReadAllText(file, Encodings.Win1250);
                if (!string.IsNullOrEmpty(text)) config = (T)Deserialize(text, typeof(T));
            }
            catch (FileNotFoundException)
            {
            }

            if (config == null)
            {
                config = new T();
                WriteData(file, config);
            }

            return config;
        }

        /// <summary>
        ///     Zapise data do XML suboru
        /// </summary>
        /// <param name="file">cesta k suboru</param>
        /// <param name="obj">data</param>
        public static void WriteData<T>(string file, T obj)
        {
            SerializeToFile(file, RuntimeHelpers.GetObjectValue(obj));
        }

        internal static string Serialize(object oObject, bool bIndent, XmlSerializer oSerializer = null)
        {
            oSerializer ??= new XmlSerializer(oObject.GetType());

            var stringWriter = new StringWriter();
            var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
            {
                Indent = bIndent,
                OmitXmlDeclaration = true
            });

            oSerializer.Serialize(xmlWriter, RuntimeHelpers.GetObjectValue(oObject));
            var text = stringWriter.ToString();

            if (text.Length < 10000 && text.IndexOf(constXMLNS1, StringComparison.Ordinal) < 0 &&
                text.IndexOf(constXMLNS2, StringComparison.Ordinal) < 0) text = text.Replace(constXMLRedundant, "");

            return text.Trim(" \r\n".ToCharArray());
        }

        internal static void SerializeToFile(string sFName, object oObject, Encoding oEncoding = null, XmlSerializer oSerializer = null)
        {
            var text = Serialize(RuntimeHelpers.GetObjectValue(oObject), true, oSerializer);

            oEncoding ??= Encodings.Win1250;

            text = "<?xml version=\"1.0\" encoding=\"" + oEncoding.WebName + "\"?>\r\n" + text;

            File.WriteAllText(sFName, text, oEncoding);
        }

        internal static object Deserialize(string s, Type Type)
        {
            if (string.IsNullOrEmpty(s)) throw new Exception("XML reťazec je prázdny.");

            var xmlSerializer = new XmlSerializer(Type);
            var input = new StringReader(s);
            var xmlReader = new XmlTextReader(input);

            return xmlSerializer.Deserialize(xmlReader);
        }
    }
}