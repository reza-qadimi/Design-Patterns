namespace ChainOfResponsibility.Text;

public class TrimHandler : Base.Handler<string?>
{
	public TrimHandler() : base()
	{
	}

	public override string? Handle(string? request)
	{
		if (request == null)
		{
			return request;
		}

		var value =
			request.Trim();

		value =
			CallNext(value);

		return value;
	}
}
