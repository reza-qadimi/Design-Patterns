namespace Composite.FileSystem;

public class Directory : object, IFileSystem
{
	public static IFileSystem Create(List<IFileSystem> fileSystems)
	{
		var createdDirectory =
			new Directory(fileSystems: fileSystems);

		return createdDirectory;
	}

	private Directory() : base()
	{
		_fileSystems = new List<IFileSystem>();
	}

	private Directory(List<IFileSystem> fileSystems) : this()
	{
		_fileSystems = fileSystems;
	}

	private readonly List<IFileSystem> _fileSystems;

	public virtual IReadOnlyList<IFileSystem> FileSystems
	{
		get
		{
			return _fileSystems.AsReadOnly();
		}
	}

	public int GetSize()
	{
		var size = 0;

		foreach (var fileSystem in FileSystems)
		{
			size += fileSystem.GetSize();
		}

		return size;
	}
}
