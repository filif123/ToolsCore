// <copyright file="UtilsTest.cs">Copyright ©  2021</copyright>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Suppression;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolsCore.Tools;

// ReSharper disable InvokeAsExtensionMethod

namespace ToolsCore.Tests
{
    /// <summary>Tato třída obsahuje parametrizované testy jednotek pro Utils.</summary>
    [PexClass(typeof(Utils))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class UtilsTest
    {
        public static void ThrowsException<T>(Action action) where T : Exception
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                PexAssert.AreEqual(typeof(T), e.GetType());
            }
        }

        /// <summary>Třída testu sub pro ANSItoUTF(Byte[]).</summary>
        [PexMethod(MaxRuns = 3)]
        public string ANSItoUTFTest(byte[] data)
        {
            string result = data.ANSItoUTF();
            return result;
        }

        /// <summary>Třída testu sub pro ANSItoUTF(String).</summary>
        [PexMethod(MaxRuns = 3)]
        public string ANSItoUTFTest01(string data)
        {
            string result = data.ANSItoUTF();
            return result;
        }

        /// <summary>Třída testu sub pro Arrow(Arrow).</summary>
        [PexMethod]
        public string ArrowTest(Arrow type)
        {
            string result = Utils.Arrow(type);
            return result;
        }

        /// <summary>Třída testu sub pro BitArrayToString(BitArray).</summary>
        [PexMethod]
        public string BitArrayToStringTest(BitArray bits)
        {
            string result = Utils.BitArrayToString(bits);
            return result;
        }

        /// <summary>Třída testu sub pro CombinePath(String[]).</summary>
        [PexMethod(MaxRunsWithoutNewTests = 200)]
        public string CombinePathTest(string[] paths)
        {
            string result = Utils.CombinePath(paths);
            return result;
        }

        /// <summary>Třída testu sub pro ContainsAllItems(IEnumerable`1&lt;!!0&gt;, IEnumerable`1&lt;!!0&gt;).</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public bool ContainsAllItemsTest<T>(IEnumerable<T> containingList, IEnumerable<T> lookupList)
        {
            bool result = Utils.ContainsAllItems(containingList, lookupList);
            return result;
        }

        /// <summary>Třída testu sub pro CopyDirectory(String, String).</summary>
        [PexMethod]
        public void CopyDirectoryTest(string sourcePath, string destinationPath)
        {
            Utils.CopyDirectory(sourcePath, destinationPath);
        }

        /// <summary>Třída testu sub pro ElementAtOrDefaultStr(IEnumerable`1&lt;String&gt;, Int32, String).</summary>
        [PexMethod]
        public string ElementAtOrDefaultStrTest(IEnumerable<string> source, int index, string def)
        {
            if (source is null) ThrowsException<NullReferenceException>(() => Utils.ElementAtOrDefaultStr(null, index, def));
            string result = Utils.ElementAtOrDefaultStr(source, index, def);
            return result;
        }

        /// <summary>Třída testu sub pro EqualsIgnoreCase(String, String).</summary>
        [PexMethod]
        public bool EqualsIgnoreCaseTest(string str1, string str2)
        {
            bool result = Utils.EqualsIgnoreCase(str1, str2);
            return result;
        }

        /// <summary>Třída testu sub pro ExReplace(String, String, String, StringComparison).</summary>
        [PexMethod]
        public string ExReplaceTest(string str, string oldValue, string newValue, StringComparison comparisonType)
        {
            string result = Utils.ExReplace(str, oldValue, newValue, comparisonType);
            return result;
        }

        /// <summary>Třída testu sub pro GetDirectoryName(String).</summary>
        [PexMethod]
        public string GetDirectoryNameTest(string path)
        {
            string result = Utils.GetDirectoryName(path);
            return result;
        }

        /// <summary>Třída testu sub pro GetRelativePath(String, String).</summary>
        [PexMethod]
        public string GetRelativePathTest(string filePath, string folderPath)
        {
            string result = Utils.GetRelativePath(filePath, folderPath);
            return result;
        }

        /// <summary>Třída testu sub pro GetSystemFontNames().</summary>
        [PexMethod]
        public List<string> GetSystemFontNamesTest()
        {
            List<string> result = Utils.GetSystemFontNames();
            return result;
        }

        /// <summary>Třída testu sub pro IsFontMonospaced(Graphics, Font).</summary>
        [PexMethod]
        public bool IsFontMonospacedTest(Graphics g, Font ft)
        {
            bool result = Utils.IsFontMonospaced(g, ft);
            return result;
        }

        /// <summary>Třída testu sub pro IsInt(String).</summary>
        [PexMethod]
        public bool IsIntTest(string num)
        {
            bool result = Utils.IsInt(num);
            return result;
        }

        /// <summary>Třída testu sub pro IsTime(String).</summary>
        [PexMethod]
        public bool IsTimeTest(string str)
        {
            bool result = Utils.IsTime(str);
            return result;
        }

        /// <summary>Třída testu sub pro LengthIntToString(Int32).</summary>
        [PexMethod]
        public string LengthIntToStringTest(int len)
        {
            string result = Utils.LengthIntToString(len);
            return result;
        }

        /// <summary>Třída testu sub pro LineIsEOF(ReadStartChar).</summary>
        [PexMethod]
        public bool LineIsEOFTest(ReadStartChar ch)
        {
            bool result = Utils.LineIsEOF(ch);
            return result;
        }

        /// <summary>Třída testu sub pro LineIsEmpty(ReadStartChar).</summary>
        [PexMethod]
        public bool LineIsEmptyTest(ReadStartChar ch)
        {
            bool result = Utils.LineIsEmpty(ch);
            return result;
        }

        /// <summary>Třída testu sub pro PadZeros(Int32, Int32).</summary>
        [PexMethod]
        public string PadZerosTest(int num, int pocetCifier)
        {
            string result = Utils.PadZeros(num, pocetCifier);
            return result;
        }

        /// <summary>Třída testu sub pro ParseDateAlts(String).</summary>
        [PexMethod]
        public DateTime ParseDateAltsTest(string text)
        {
            var result = Utils.ParseDateAlts(text);
            return result;
        }

        /// <summary>Třída testu sub pro ParseDate(String).</summary>
        [PexMethod]
        public DateTime ParseDateTest(string text)
        {
            var result = Utils.ParseDate(text);
            return result;
        }

        /// <summary>Třída testu sub pro ParseHEX(String).</summary>
        [PexMethod]
        public Color ParseHEXTest(string hex)
        {
            var result = Utils.ParseHEX(hex);
            return result;
        }

        /// <summary>Třída testu sub pro ParseIntOrDefault(String, Int32).</summary>
        [PexMethod]
        public int ParseIntOrDefaultTest(string nums, int def)
        {
            int result = Utils.ParseIntOrDefault(nums, def);
            return result;
        }

        /// <summary>Třída testu sub pro ParseIntOrNull(String, Nullable`1&lt;Int32&gt;).</summary>
        [PexMethod]
        public int? ParseIntOrNullTest(string nums, int? def)
        {
            int? result = Utils.ParseIntOrNull(nums, def);
            return result;
        }

        /// <summary>Třída testu sub pro ParseStringOrDefault(String, String).</summary>
        [PexMethod]
        public string ParseStringOrDefaultTest(string str, string def)
        {
            string result = Utils.ParseStringOrDefault(str, def);
            return result;
        }

        /// <summary>Třída testu sub pro ParseTime(String).</summary>
        [PexMethod]
        public DateTime ParseTimeTest(string text)
        {
            var result = Utils.ParseTime(text);
            return result;
        }

        /// <summary>Třída testu sub pro Quote(String).</summary>
        [PexMethod]
        public string QuoteTest(string text)
        {
            string result = Utils.Quote(text);
            return result;
        }

        /// <summary>Třída testu sub pro RemoveDiacritics(String).</summary>
        [PexMethod]
        public string RemoveDiacriticsTest(string text)
        {
            string result = Utils.RemoveDiacritics(text);
            return result;
        }

        /// <summary>Třída testu sub pro RestartApp().</summary>
        [PexIgnore("")]
        public void RestartAppTest()
        {
            Utils.RestartApp();
        }

        /// <summary>Třída testu sub pro ShowError(String, MessageBoxButtons).</summary>
        [PexIgnore("GUI")]
        public void ShowErrorTest(string text, MessageBoxButtons buttons)
        {
            Utils.ShowError(text, buttons);
        }

        /// <summary>Třída testu sub pro ShowInfo(String, String, MessageBoxButtons).</summary>
        [PexIgnore("GUI")]
        public DialogResult ShowInfoTest(string text, string title, MessageBoxButtons buttons)
        {
            var result = Utils.ShowInfo(text, title, buttons);
            return result;
        }

        /// <summary>Třída testu sub pro ShowQuestion(String, MessageBoxButtons).</summary>
        [PexIgnore("GUI")]
        public DialogResult ShowQuestionTest(string text, MessageBoxButtons buttons)
        {
            var result = Utils.ShowQuestion(text, buttons);
            return result;
        }

        /// <summary>Třída testu sub pro ShowWarning(String, MessageBoxButtons).</summary>
        [PexIgnore("GUI")]
        public DialogResult ShowWarningTest(string text, MessageBoxButtons buttons)
        {
            var result = Utils.ShowWarning(text, buttons);
            return result;
        }

        /// <summary>Třída testu sub pro StringToBitArray(String).</summary>
        [PexMethod]
        public BitArray StringToBitArrayTest(string bits)
        {
            var result = Utils.StringToBitArray(bits);
            return result;
        }

        /// <summary>Třída testu sub pro ToBool(Int32).</summary>
        [PexMethod]
        public bool ToBoolTest(int hodnota)
        {
            bool result = Utils.ToBool(hodnota);
            return result;
        }

        /// <summary>Třída testu sub pro ToHEX(Color).</summary>
        [PexMethod]
        public string ToHEXTest(Color c)
        {
            string result = Utils.ToHEX(c);
            return result;
        }

        /// <summary>Třída testu sub pro ToNumber(Boolean).</summary>
        [PexMethod]
        public int ToNumberTest(bool hodnota)
        {
            int result = Utils.ToNumber(hodnota);
            return result;
        }

        /// <summary>Třída testu sub pro TryParseDateAlts(String, DateTime&amp;).</summary>
        [PexMethod]
        public bool TryParseDateAltsTest(string text, out DateTime date)
        {
            bool result = Utils.TryParseDateAlts(text, out date);
            return result;
        }

        /// <summary>Třída testu sub pro TryParseHEX(String).</summary>
        [PexMethod]
        public Color? TryParseHEXTest(string hex)
        {
            Color? result = Utils.TryParseHEX(hex);
            return result;
        }

        /// <summary>Třída testu sub pro TryParseTime(String, DateTime&amp;).</summary>
        [PexMethod]
        public bool TryParseTimeTest(string text, out DateTime time)
        {
            bool result = Utils.TryParseTime(text, out time);
            return result;
        }

        /// <summary>Třída testu sub pro UTFtoANSI(Byte[]).</summary>
        [PexMethod(MaxRuns = 3)]
        public string UTFtoANSITest(byte[] data)
        {
            string result = Utils.UTFtoANSI(data);
            return result;
        }

        /// <summary>Třída testu sub pro UTFtoANSI(String).</summary>
        [PexMethod(MaxRuns = 3)]
        public string UTFtoANSITest01(string data)
        {
            string result = Utils.UTFtoANSI(data);
            return result;
        }

        /// <summary>Třída testu sub pro ValidateShortcut(Keys).</summary>
        [PexMethod]
        public bool ValidateShortcutTest(Keys keys)
        {
            bool result = Utils.ValidateShortcut(keys);
            return result;
        }
    }
}
