namespace Builder.Maze;

public interface IMazeBuilder
{
	void AddRoom(int index);

	void AddDoor(int from, int to);

	IMaze Build();
}
