namespace Visitor.BasicVisitor.Visitors;

public interface IFileSystemVisitor
{
	public void Visit(FileSystem.File file);
	public void Visit(FileSystem.Directory directory);
}


public class FileSystemVisitor : IFileSystemVisitor
{
	public FileSystemVisitor() : base()
	{
	}

	public virtual void Visit(FileSystem.File file)
	{
	}

	public virtual void Visit(FileSystem.Directory directory)
	{
	}
}
