namespace Composite.FileSystem;

public class File : object, IFileSystem
{
	public static IFileSystem Create(string name, int size)
	{
		var createdFile =
			new File(name: name, size: size);

		return createdFile;
	}

	private File() : base()
	{
	}

	private File(string name, int size) : this()
	{
		Name = name;
		Size = size;
	}

	public int Size { get; private set; }

	public string? Name { get; private set; }

	public int GetSize()
	{
		return Size;
	}
}
