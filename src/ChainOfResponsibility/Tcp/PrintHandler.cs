namespace ChainOfResponsibility.Tcp;

public class PrintHandler : Base.Handler<TcpPacket>
{
	public PrintHandler() : base()
	{
	}

	public override void Handle(TcpPacket request)
	{
		if (request.Message == "PRINT")
		{
			request.Response = "SUCCESS";
		}
		else
		{
			CallNext(request);
		}
	}
}
