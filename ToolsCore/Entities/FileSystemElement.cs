using ToolsCore.Tools;

namespace ToolsCore.Entities;

public abstract class FileSystemElement
{
    protected FileSystemElement(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public static implicit operator FileSystemElement(FileSystemInfo fsi)
    {
        switch (fsi)
        {
            case DirectoryInfo di:
                return new DirectoryElement(di);
            case FileInfo fi:
                if (fi.Extension.ToUpper() is SoundFileElement.WAV_EXT or SoundFileElement.EWA_EXT)
                    return new SoundFileElement(fi);
                return new OtherFileElement(fi);
            default:
                return null;
        }
    }
}

public class BackButtonElement : FileSystemElement
{
    public BackButtonElement(DirectoryElement parent) : base("...")
    {
        ParentDirectory = parent;
    }

    public DirectoryElement ParentDirectory { get; }
}

public class DirectoryElement : FileSystemElement
{
    public DirectoryElement(DirectoryInfo dirinfo) : base(dirinfo.Name)
    {
        DirInfo = dirinfo;
        Children = new List<FileSystemElement>();
        var fis = dirinfo.GetFileSystemInfos();
        for (var i = 0; i < fis.Length; i++)
        {
            var fi = fis[i];
            Children.Add(fi);
            switch (Children[i])
            {
                case DirectoryElement dir:
                    dir.Parent = this;
                    break;
                case FileElement fe:
                    fe.Parent = this;
                    break;
            }
        }
    }

    public DirectoryElement(string absPath) : this(new DirectoryInfo(absPath))
    {
    }

    public DirectoryElement Parent { get; set; }

    public DirectoryInfo DirInfo { get; set; }

    public List<FileSystemElement> Children { get; }

    public FyzGroup Group { get; set; }

    public int GetCountChildren() => Children.Count;
}

public abstract class FileElement : FileSystemElement
{
    protected FileElement(FileInfo fileinfo) : base(fileinfo.Name)
    {
        FileInfo = fileinfo;
    }

    protected FileElement(string absPath) : base(Path.GetFileName(absPath))
    {
        FileInfo = new FileInfo(absPath);
    }

    public FileInfo FileInfo { get; set; }

    public DirectoryElement Parent { get; set; }
}

public class SoundFileElement : FileElement
{
    public const string WAV_EXT = ".WAV";
    public const string EWA_EXT = ".EWA";

    public SoundFileElement(FileInfo fileinfo) : base(fileinfo)
    {
        Duration = -1;
    }

    public SoundFileElement(string file) : base(file)
    {
        Duration = -1;
    }

    public int Duration { get; set; }

    public string DurationText => Utils.LengthIntToString(Duration);

    public FyzSound Sound { get; set; }
}

public class OtherFileElement : FileElement
{
    public OtherFileElement(FileInfo fileinfo) : base(fileinfo)
    {
    }

    public OtherFileElement(string file) : base(file)
    {
    }
}