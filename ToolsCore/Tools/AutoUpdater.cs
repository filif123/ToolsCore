using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ToolsCore.Tools
{
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
            var thisVersion = Utils.GetAppVersion(thisVersionAsString);

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
                var web = new WebClient();
                //var stream = web.OpenRead("http://iniss.6f.sk/gvdeditor-updater/update.txt");
                var stream = web.OpenRead(GlobSettings.LinkUpdater);
                using var reader = new StreamReader(stream ?? throw new InvalidOperationException());
                var text = reader.ReadToEnd();
                var csv = new CsvStringReader(text);

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
    }
}