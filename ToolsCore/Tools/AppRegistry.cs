using Microsoft.Win32;

namespace ToolsCore.Tools;

/// <summary>
///     Trieda spracujuca zoznam poslednych pouzivanych priecinkov s datami.
/// </summary>
public static class AppRegistry
{
    /// <summary>
    ///     Nazov kluca v Registy so zoznamom poslednych pouzivanych priecinkov s datami.
    /// </summary>
    private const string REG_RECENT_DIRS = "RecentDirs";

    /// <summary>
    ///     Nazov kluca v Registy so zoznamom poslednych pouzivanych suborov.
    /// </summary>
    private const string REG_RECENT_FILES = "RecentFiles";

    /// <summary>
    ///     Vrati zoznam vsetkych ciest poslednych pouzivanych priecinkov s datami
    ///     podla nazvu programu <paramref name="productName"/>.<br></br>
    ///     Ak kluc v Registri s tymto zoznamom neexisstuje, metoda vrati prazdny list.
    /// </summary>
    /// <param name="productName">Nazov programu.</param>
    /// /// <param name="forFiles">Ci sa jedna o pracu so subormi.</param>
    /// <returns>zoznam ciest.</returns>
    public static List<string> GetRecentDirs(string productName, bool forFiles = false)
    {
        var key = Registry.CurrentUser.OpenSubKey($"SOFTWARE\\{productName}");
        var dirs = new HashSet<string>();

        var value = key?.GetValue(forFiles ? REG_RECENT_FILES : REG_RECENT_DIRS);

        if (value == null) 
            return dirs.ToList();

        var itemsString = value.ToString();
        var items = itemsString.Split(';');

        foreach (var item in items)
            if (!string.IsNullOrEmpty(item))
                dirs.Add(item);

        return dirs.ToList();
    }

    /// <summary>
    ///     Prida novu cestu na koniec zoznamu poslednych pouzivanych priecinkov
    ///     s datami podla nazvu programu <paramref name="productName"/>.<br></br>
    ///     Ak kluc v Registry neexistuje, vytvori sa a prida zadanu cestu path.
    /// </summary>
    /// <param name="productName">Nazov programu.</param>
    /// <param name="path">Cesta k priecinku.</param>
    /// <param name="forFiles">Ci sa jedna o pracu so subormi.</param>
    public static void SetNewRecentDir(string productName, string path, bool forFiles = false)
    {
        var key = Registry.CurrentUser.CreateSubKey($"SOFTWARE\\{productName}");

        if (key == null) 
            return;

        var sb = new StringBuilder();
        var items = GetRecentDirs(productName);
        foreach (var item in items)
        {
            if (item == path) return;

            sb.Append(";");
            sb.Append(item);
        }

        sb.Append(";");
        sb.Append(path);

        key.SetValue(forFiles ? REG_RECENT_FILES : REG_RECENT_DIRS, sb.ToString());
    }
}