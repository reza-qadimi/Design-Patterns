namespace ChainOfResponsibility.Text;

public class UppercaseHandler : Base.Handler<string?>
{
	public UppercaseHandler() : base()
	{
	}

	public override string? Handle(string? request)
	{
		if (request == null)
		{
			return request;
		}

		var value =
			request.ToUpper();

		value =
			CallNext(value);

		return value;
	}
}
