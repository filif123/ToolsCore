using System.Net;

namespace ToolsCore.Tools;

/// <summary>
///     Trieda zisťujúca aktuálnosť spustenej verzie programu
/// </summary>
public static class AutoUpdater
{
    /// <summary>
    ///     Zistí, či je aktuálne spustená verzia programu aktuálna. V prípade nedostupnosti zdroja vráti
    ///     <see langword="false" />.
    /// </summary>
    /// <param name="thisVersionAsString">varzia tohto programu ako retazec</param>
    /// <param name="newVersion">nova verzia ako retazec alebo <see langword="null" />, ak novsia verzia neexistuje</param>
    /// <returns></returns>
    public static bool UpdateAvailable(string thisVersionAsString, out string newVersion)
    {
        var thisVersion = new Version(thisVersionAsString);

        var allVersions = GetAllVersions();
        foreach (var v in allVersions)
            if (v > thisVersion)
            {
                newVersion = v.ToString();
                return true;
            }

        newVersion = null;
        return false;
    }

    /// <summary>
    ///     Vráti, zoznam všetkých verzií zo servera. V prípade nedostupnosti zdroja vráti prázdny zoznam.
    /// </summary>
    /// <returns></returns>
    private static IEnumerable<Version> GetAllVersions()
    {
        var allversions = new List<Version>();
        
        try
        {
            var web = new TimedWebClient();
            var csv = new CsvStringReader(web.DownloadString(GlobSettings.LinkUpdater));
            //BUG: stranka sa neda otvorit (chyba je vo vsetkych verziach programu)
            for (var i = 0; i < csv.RowCount; i++)
            {
                var version = new Version(csv[i, 0]);
                allversions.Add(version);
            }
        }
        catch
        {
            //ignored
        }

        return allversions;
    }

    private sealed class TimedWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            var w = base.GetWebRequest(address);
            if (w is not null) w.Timeout = 3000;
            return w;
        }
    }
}