namespace ChainOfResponsibility.Tcp;

public class TcpPacket : object
{
	public TcpPacket() : base()
	{
	}

	public string? Message { get; set; }

	public string? Response { get; set; }
}
