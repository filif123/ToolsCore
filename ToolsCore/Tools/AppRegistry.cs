using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace ToolsCore.Tools
{
    /// <summary>
    ///     Trieda spracujuca zoznam poslednych pouzivanych priecinkov s datami.
    /// </summary>
    public static class AppRegistry
    {
        /// <summary>
        ///     Nazov kluca v Registy so zoznamom poslednych pouzivanych priecinkov s datami.
        /// </summary>
        public const string REG_RECENT_DIRS = "RecentDirs";

        /// <summary>
        ///     Vrati zoznam vsetkych ciest poslednych pouzivanych priecinkov s datami
        ///     podla nazvu programu <paramref name="productName"/>.<br></br>
        ///     Ak kluc v Registri s tymto zoznamom neexisstuje, metoda vrati prazdny list.
        /// </summary>
        /// <param name="productName">Nazov programu.</param>
        /// <returns>zoznam ciest.</returns>
        public static List<string> GetRecentDirs(string productName)
        {
            var key = Registry.CurrentUser.OpenSubKey($"SOFTWARE\\{productName}");
            var dirs = new HashSet<string>();

            if (key?.GetValue(REG_RECENT_DIRS) != null)
            {
                var dirsString = key.GetValue(REG_RECENT_DIRS).ToString();
                var dirsArray = dirsString.Split(';');

                foreach (var dir in dirsArray)
                    if (!string.IsNullOrEmpty(dir))
                        dirs.Add(dir);
            }

            return dirs.ToList();
        }

        /// <summary>
        ///     Prida novu cestu na koniec zoznamu poslednych pouzivanych priecinkov
        ///     s datami podla nazvu programu <paramref name="productName"/>.<br></br>
        ///     Ak kluc v Registry neexistuje, vytvori sa a prida zadanu cestu path.
        /// </summary>
        /// <param name="productName">Nazov programu.</param>
        /// <param name="path">Cesta k priecinku.</param>
        public static void SetNewRecentDir(string productName, string path)
        {
            var key = Registry.CurrentUser.CreateSubKey($"SOFTWARE\\{productName}");

            if (key != null)
            {
                var sb = new StringBuilder();
                var dirs = GetRecentDirs(productName);
                foreach (var dir in dirs)
                {
                    if (dir == path) return;

                    sb.Append(";");
                    sb.Append(dir);
                }

                sb.Append(";");
                sb.Append(path);

                key.SetValue(REG_RECENT_DIRS, sb.ToString());
            }
        }
    }
}