namespace CompositeWithBuilder.Sales;

public class SalesAgent : SalesUnit
{
	private int _credits;

	public SalesAgent(string name) : base(name: name)
	{
	}

	public override int GetCredit()
	{
		return _credits;
	}

	public override void PayCommission(int amount)
	{
		_credits += amount;
	}

	public override int UnitsCount()
	{
		var unitsCount = 1;

		return unitsCount;
	}
}
