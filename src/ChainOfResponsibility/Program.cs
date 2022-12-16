namespace ChainOfResponsibility;

public static class Program : object
{
	static Program()
	{
	}

	static void Main(string[] args)
	{
		var request = " test ";

		var handler = GetHandler();

		handler?.Handle(request);

		System.Console.WriteLine(request);

		System.Console.ReadLine();

		var packet = new Tcp.TcpPacket()
		{
			Message = "PRINT"
		};

		var chain = CreateHandler();

		chain.Handle(packet);

		System.Console.WriteLine(packet.Response);
	}

	private static Tcp.Base.IHandler<Tcp.TcpPacket> CreateHandler()
	{
		var chain =
			new Tcp.Base.ChainBuilder<Tcp.TcpPacket>()
			.With<Tcp.HeartbeatHandler>()
			.With<Tcp.HandshakeHandler>()
			.With<Tcp.PrintHandler>()
			//TODO: move this from here
			.With(Tcp.Base.NullHandler.Instance)
			.Build();

		return chain;
	}

	private static Text.Base.IHandler<string?>? GetHandler()
	{
		var handler =
			new Text.Base.ChainBuilder<string?>()
			.With<Text.TrimHandler>()
			.With<Text.UppercaseHandler>()
			.Build();

		return handler;
	}

	//var myBuilder =
	//	builder
	//	.With(new TrimHandler())
	//	.With(new UppercaseHandler())
	//	.Build();

	// return myBuilder;

	// var trimHandler = new TrimHandler();
	// var uppercaseHandler = new TrimHandler();
	// trimHandler.SetSuccessor(uppercaseHandler);
	// return trimHandler;
}
