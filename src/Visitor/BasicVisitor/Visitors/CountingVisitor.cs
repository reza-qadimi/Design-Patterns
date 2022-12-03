namespace Visitor.BasicVisitor.Visitors;

public class CountingVisitor : FileSystemVisitor
{
	public int FileCount { get; private set; }
	public int DirectoryCount { get; private set; }

	public override void Visit(FileSystem.File file)
	{
		FileCount++;
	}
	public override void Visit(FileSystem.Directory directory)
	{
		DirectoryCount++;
	}
}
