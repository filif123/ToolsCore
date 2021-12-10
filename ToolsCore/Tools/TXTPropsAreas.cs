namespace ToolsCore.Tools;

/// <summary>
///     Trieda reprezentujuca zoznam poli s obsahom bez vlastnosti.
/// </summary>
public class TXTPropsAreas
{
    private readonly string fileName;
    private readonly Dictionary<string, string> dictionary;

    /// <summary>
    ///     Vytvori novu instanciu triedy <see cref="TXTPropsAreas"/>.
    /// </summary>
    /// <param name="file">Cesta k suboru do/z ktore sa budu ukladat/nacitat subory.</param>
    /// <param name="write">Ak je false, zoznam vlastnosti a hodnot sa nacita zo suboru.</param>
    public TXTPropsAreas(string file, bool write = false)
    {
        fileName = file;
        dictionary = new Dictionary<string, string>();

        if (!write) 
            LoadFromFile(file);
    }

    /// <summary>
    ///     Vrati obsah pola zadaneho nazvom pola <paramref name="area"/>.
    ///     Ak pole s takymto nazvom nenajde, vrati <see langword="null"/>.
    /// </summary>
    /// <param name="area">Nazov pola.</param>
    /// <returns></returns>
    public string Get(string area) => dictionary.ContainsKey(area) ? dictionary[area] : null;

    /// <summary>
    ///     Vrati zoznam vsetkych nazvov poli, ktore sa nachadzaju v slovniku.
    /// </summary>
    /// <returns>zoznam vsetkych nazvov poli, ktore sa nachadzaju v slovniku.</returns>
    public IEnumerable<string> GetAreas() => dictionary.Keys.ToList();

    /// <summary>
    ///     Nastavi obsah pola. Ak zadany nazov pola <paramref name="area"/> nenajde v slovniku poli,
    ///     vytvori nove pole s tymto nazvom a nastavi jej zadany obsah specifikovany v parametri <paramref name="value"/>.
    /// </summary>
    /// <param name="area">Nazov pola.</param>
    /// <param name="value">Obsah pola.</param>
    public void Set(string area, object value)
    {
        if (dictionary.ContainsKey(area))
            dictionary[area] = value.ToString();
        else
            dictionary.Add(area, value.ToString());
    }

    /// <summary>
    ///     Ulozi zoznam poli do suboru.
    /// </summary>
    public void Save()
    {
        var file = new StreamWriter(fileName, false, Encodings.Win1250);

        foreach (var area in dictionary.Keys)
        {
            file.WriteLine("[" + area + "]");
            file.WriteLine(dictionary[area]);
            file.WriteLine(Environment.NewLine);
        }

        file.Close();
    }

    /// <summary>
    ///     Nacita zoznam poli zo suboru.
    /// </summary>
    private void LoadFromFile(string file)
    {
        string actualArea = null;
        var sb = new StringBuilder();

        foreach (var line in File.ReadAllLines(file, Encodings.Win1250))
        {
            if (!string.IsNullOrEmpty(line) && !line.StartsWith(";") && line.StartsWith("[") && line.EndsWith("]"))
            {
                if (sb.Length != 0 || !string.IsNullOrEmpty(actualArea)) 
                    dictionary.Add(actualArea!, sb.ToString());

                sb = new StringBuilder();
                var s = line.Replace("[", "");
                actualArea = s.Replace("]", "");
            }

            if (!string.IsNullOrEmpty(line) && !line.StartsWith(";") && !line.StartsWith("[") && !line.EndsWith("]"))
                sb.AppendLine(line);
        }

        if (actualArea is not null)
        {
            dictionary.Add(actualArea, sb.ToString());
        }
    }
}