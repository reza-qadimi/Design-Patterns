namespace Builder.Maze;

public interface IMaze
{
	byte[] Data { get; set; }
}

public class Maz : object, IMaze
{
	public Maz(byte[] data) : base()
	{
		Data = data;
	}

	public byte[] Data { get; set; }
}

public interface IMazeBuilder
{
	void AddRoom(int index);

	void AddDoor(int from, int to);

	IMaze Build();
}

public class StandardMazeBuilder : object, IMazeBuilder
{
	public StandardMazeBuilder() : base()
	{
	}

	public void AddDoor(int from, int to)
	{
		throw new System.NotImplementedException();
	}

	public void AddRoom(int index)
	{
		throw new System.NotImplementedException();
	}

	public IMaze Build()
	{
		throw new System.NotImplementedException();
	}
}

public class CountinMazeBuilder : object, IMazeBuilder
{
	public CountinMazeBuilder() : base()
	{
	}

	public void AddDoor(int from, int to)
	{
		throw new System.NotImplementedException();
	}

	public void AddRoom(int index)
	{
		throw new System.NotImplementedException();
	}

	public IMaze Build()
	{
		throw new System.NotImplementedException();
	}
}

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
