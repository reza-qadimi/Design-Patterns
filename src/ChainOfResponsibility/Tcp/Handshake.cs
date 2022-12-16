namespace ChainOfResponsibility.Tcp;

public class HandshakeHandler : Base.Handler<TcpPacket>
{
	public HandshakeHandler() : base()
	{
	}

	private bool _isAuthenticated;

	public override void Handle(TcpPacket request)
	{
		if (request.Message == "HAND_SHAKE")
		{
			_isAuthenticated = true;

			request.Response = "SUCCESS";
		}
		else
		{
			if (_isAuthenticated)
			{
				CallNext(request);
			}
			else
			{
				request.Response = "UNAUTHORIZED_ACCESS";
			}
		}
	}
}
