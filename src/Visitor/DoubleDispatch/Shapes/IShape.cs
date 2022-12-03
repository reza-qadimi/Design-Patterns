using Visitor.DoubleDispatch.Boards;

namespace Visitor.DoubleDispatch.Shapes;

public interface IShape
{
	void Draw(Boards.IBoard board);
}

public class Circle : object, IShape
{
	public Circle() : base()
	{
	}

	public void Draw(IBoard board)
	{
		board.Visit(this);
	}
}

public class Square : object, IShape
{
	public Square() : base()
	{
	}

	public void Draw(IBoard board)
	{
		board.Visit(this);
	}
}

public class Rectangle : object, IShape
{
	public Rectangle() : base()
	{
	}

	public void Draw(IBoard board)
	{
		board.Visit(this);
	}
}
