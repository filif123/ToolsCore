using System.Collections.Generic;
using System.Drawing;

namespace ToolsCore.XML
{
    /// <summary>
    ///     Trieda reprezentujuca kategoriu farieb, spolu s doplnkovimi nastaveniami.
    /// </summary>
    public class ColorCategory
    {
        /// <summary>
        ///     Vrati alebo nastavi nazov katagorie.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Vrati alebo nastavi pismo pouzite pre danu kategoriu.
        /// </summary>
        public Font Font { get; set; }

        /// <summary>
        ///     Vrati alebo nastavi povolenie/zabranenie v uprave pisma pre danu kategoriu v GUI.
        /// </summary>
        public bool DisableFontEdit { get; set; }

        /// <summary>
        ///     Vrati alebo nastavi zoznam jednotlivych nastaveni farieb pre istu cast programu.
        /// </summary>
        public List<ColorSetting> Settings { get; set; }

        /// <inheritdoc/>
        public override string ToString() => Name;
    }
}