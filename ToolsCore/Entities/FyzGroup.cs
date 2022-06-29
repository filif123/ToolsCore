using ExControls;

namespace ToolsCore.Entities;

public class FyzGroup
{
    /// <summary>Initializes a new instance of the <see cref="FyzGroup" /> class.</summary>
    public FyzGroup(FyzLanguage lang, string key, string name, string relativePath)
    {
        Language = lang;
        Key = key;
        Name = name;
        RelativePath = relativePath;
        Sounds = new ExBindingList<FyzSound>();
        Type = FyzGroupType.Parse(name);
    }

    public FyzGroup(FyzGroup original)
    {
        Language = original.Language;
        Key = string.Copy(original.Key);
        Name = string.Copy(original.Name);
        RelativePath = string.Copy(original.RelativePath);
        Sounds = original.Sounds;
        Type = original.Type;
    }

    /// <summary>
    ///     Kluc skupiny (v programe ZvukBase sa neda menit).
    /// </summary>
    public string Key { get; }

    /// <summary>
    ///     Nazov skupiny (v programe ZvukBase sa da menit).
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     Relativna cesta k skupine zvukov.
    /// </summary>
    public string RelativePath { get; }

    /// <summary>
    ///     Zvuky skupiny.
    /// </summary>
    public IList<FyzSound> Sounds { get; }

    /// <summary>
    ///     Jazyk, ku ktoremu tato skupina zvukov patri.
    /// </summary>
    public FyzLanguage Language { get; set; }

    /// <summary>
    ///     Odkaz na fyzicky priecinok skupiny zvukov.
    /// </summary>
    public DirectoryElement Directory { get; set; }

    /// <summary>
    ///     Typ priečinka podľa zvukov, ktoré obsahuje.
    /// </summary>
    public FyzGroupType Type { get; }

    public void Add(FyzSound sound) => Sounds.Add(sound);

    /// <summary>Returns a string that represents the current object.</summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() => Name;

    public string GetAbsPath(string pathToBank)
    {
        if (Language == null)
            throw new ArgumentNullException(nameof(Language));
        if (string.IsNullOrEmpty(pathToBank))
            throw new ArgumentNullException(nameof(pathToBank));

        var path = new StringBuilder(pathToBank);

        path.Append(Language.RelativePath);
        path.Append(RelativePath);

        return path.ToString();
    }
}