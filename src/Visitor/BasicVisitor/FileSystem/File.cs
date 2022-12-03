namespace Visitor.BasicVisitor.FileSystem;

public class File : FileSystemItem
{

	public File(long size) : base()
	{
		_size = size;
	}

	private readonly long _size;

	public override long Size()
	{
		return _size;
	}

	public override void Accept(Visitors.IFileSystemVisitor visitor)
	{
		visitor.Visit(this);
	}
}
