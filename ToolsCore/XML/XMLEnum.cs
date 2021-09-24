using System;

namespace ToolsCore.XML
{
    /// <summary>
    ///     Predstavuje triedu, ktorá spracuváva Enumerácie serializovateľné do XML.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class XMLEnum<T> where T : Enum
    {
        /// <summary>
        ///     Konvertuje string na enumeraciu.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static T StringToEnum(string s) => string.IsNullOrEmpty(s) ? default : (T)Enum.Parse(typeof(T), s);

        /// <summary>
        ///     Konvertuje enumeraciu na string.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string EnumToString(T e) => Enum.GetName(typeof(T), e);
    }
}