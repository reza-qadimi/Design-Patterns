namespace Visitor.BasicVisitor.Visitors;

public class LargestFileVisitor : FileSystemVisitor
{
	private long _maxSize = 0;
	public override void Visit(FileSystem.File file)
	{
		if (_maxSize < file.Size())
		{
			_maxSize = file.Size();
		}
	}

	public long GetMaximumSize() => _maxSize;
}
