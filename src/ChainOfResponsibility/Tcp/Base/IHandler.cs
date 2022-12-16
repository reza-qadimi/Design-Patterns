namespace ChainOfResponsibility.Tcp.Base;

public interface IHandler<TRequest>
{
	void Handle(TRequest request);

	void SetSuccessor(IHandler<TRequest> next);
}
