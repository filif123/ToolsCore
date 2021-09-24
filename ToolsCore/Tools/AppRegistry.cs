using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace ToolsCore.Tools
{
    public static class AppRegistry
    {
        public const string REG_RECENT_DIRS = "RecentDirs";

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