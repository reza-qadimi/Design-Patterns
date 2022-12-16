namespace ChainOfResponsibility.Text.Base;

public interface IHandler<TRequest>
{
	TRequest Handle(TRequest request);

	void SetSuccessor(IHandler<TRequest> next);
}
