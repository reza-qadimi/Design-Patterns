namespace ChainOfResponsibility.Tcp;

public class HeartbeatHandler : Base.Handler<TcpPacket>
{
	public HeartbeatHandler() : base()
	{
	}

	public override void Handle(TcpPacket request)
	{
		if (request.Message == "HEART_BEAT")
		{
			request.Response = "ACK";
		}
		else
		{
			CallNext(request);
		}
	}
}
