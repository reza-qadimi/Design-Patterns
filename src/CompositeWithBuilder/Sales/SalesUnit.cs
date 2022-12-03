namespace CompositeWithBuilder.Sales;

public abstract class SalesUnit : object
{
	public SalesUnit() : base()
	{
	}

	public abstract int GetCredit();

	public abstract int UnitsCount();

	public abstract void PayCommission(int amount);
}
