namespace ChainOfResponsibility.Tcp.Base;

public class NullHandler: object, IHandler<Tcp.TcpPacket>
{
	public static IHandler<Tcp.TcpPacket> Instance
	{
		get
		{
			return new NullHandler();
		}
	}

	private NullHandler() : base()
	{
	}

	public void Handle(Tcp.TcpPacket request)
	{
		request.Response = "UNKNOWN_MESSAGE";
	}

	public void SetSuccessor(IHandler<Tcp.TcpPacket> next)
	{
	}
}
