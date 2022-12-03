namespace Visitor.BasicVisitor.FileSystem;

public abstract class FileSystemItem : object
{
	public FileSystemItem() : base()
	{
	}

	public string? Name { get; set; }

	public abstract long Size();

	public abstract void Accept(Visitors.IFileSystemVisitor visitor);
}
