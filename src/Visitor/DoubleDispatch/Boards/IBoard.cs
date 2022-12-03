namespace Visitor.DoubleDispatch.Boards;

public interface IBoard
{
	void Visit(Shapes.Circle shape);
	void Visit(Shapes.Square shape);
	void Visit(Shapes.Rectangle shape);
}

public class WhiteBoard : object, IBoard
{
	public void Visit(Shapes.Circle shape)
	{
		System.Console.WriteLine(value: nameof(Shapes.Circle));
	}

	public void Visit(Shapes.Square shape)
	{
		System.Console.WriteLine(value: nameof(Shapes.Square));
	}

	public void Visit(Shapes.Rectangle shape)
	{
		System.Console.WriteLine(value: nameof(Shapes.Rectangle));
	}
}
