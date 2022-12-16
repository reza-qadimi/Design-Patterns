namespace ChainOfResponsibility.Text.Base;

public class NullHandler<TRequest> : object, IHandler<TRequest>
{
	public static IHandler<TRequest> Instance
	{
		get
		{
			return new NullHandler<TRequest>();
		}
	}

	private NullHandler() : base()
	{
	}

	public TRequest Handle(TRequest request)
	{
		return request;
	}

	public void SetSuccessor(IHandler<TRequest> next)
	{
	}
}
