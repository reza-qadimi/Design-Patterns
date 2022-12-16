namespace ChainOfResponsibility.Tcp.Base;

public abstract class Handler<TRequest> : object, IHandler<TRequest>
{
	protected Handler() : base()
	{
	}

	private IHandler<TRequest>? _next;

	public abstract void Handle(TRequest request);

	public void SetSuccessor(IHandler<TRequest> next)
	{
		_next = next;
	}

	public void CallNext(TRequest request)
	{
		_next?.Handle(request: request);
	}
}
