using System.Linq;

namespace Visitor.BasicVisitor.FileSystem;

public class Directory : FileSystemItem
{
	public Directory(params FileSystemItem[] children)
	{
		_children = children.ToList();
	}

	private System.Collections.Generic.IList<FileSystemItem> _children;

	public override long Size()
	{
		long sum = 0;

		foreach (var fileSystemItem in _children)
		{
			sum += fileSystemItem.Size();
		}

		return sum;
	}

	public override void Accept(Visitors.IFileSystemVisitor visitor)
	{
		visitor.Visit(this);

		foreach (var fileSystemItem in _children)
		{
			fileSystemItem.Accept(visitor);
		}
	}
}
