namespace Builder.Maze;

/// <summary>
/// مدیریت -> Construction Process
/// میتونیم دایرکتورهای متفاوتی داشته باشیم
/// </summary>
public class MazeDirector : object
{
	public MazeDirector(IMazeBuilder builder) : base()
	{
		Builder = builder;
	}

	private IMazeBuilder Builder { get; }

	public void EasyMaze()
	{
		Builder.AddRoom(1);
		Builder.AddRoom(2);
		Builder.AddDoor(1, 2);
		Builder.AddRoom(3);
		Builder.AddDoor(2, 3);
	}

	public void DifficultMaze()
	{
		Builder.AddRoom(1);
		Builder.AddRoom(2);
		Builder.AddDoor(1, 2);
		Builder.AddRoom(3);
		Builder.AddDoor(2, 3);
		Builder.AddRoom(4);
		Builder.AddDoor(3, 4);
	}
}
