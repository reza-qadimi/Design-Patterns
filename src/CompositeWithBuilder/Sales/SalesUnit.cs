namespace CompositeWithBuilder.Sales;

public abstract class SalesUnit : object
{
	protected SalesUnit(string name) : base()
	{
		Name = name;
	}

	public string Name { get; private set; }

	public abstract int GetCredit();

	public abstract int UnitsCount();

	public abstract void PayCommission(int amount);
}
