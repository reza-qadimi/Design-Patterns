namespace Builder.Maze;

public class Maz : object, IMaze
{
	public Maz(byte[] data) : base()
	{
		Data = data;
	}

	public byte[] Data { get; set; }
}
