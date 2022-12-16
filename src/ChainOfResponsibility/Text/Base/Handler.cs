namespace ChainOfResponsibility.Text.Base;

public abstract class Handler<TRequest> : object, IHandler<TRequest>
{
	protected Handler() : base()
	{
		_next = NullHandler<TRequest>.Instance;
	}

	private IHandler<TRequest> _next;

	public abstract TRequest Handle(TRequest request);

	public void SetSuccessor(IHandler<TRequest> next)
	{
		_next = next;
	}

	public TRequest CallNext(TRequest request)
	{
		var result =
			_next.Handle(request: request);

		return result;
	}
}
