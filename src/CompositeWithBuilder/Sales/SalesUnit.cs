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

public class SalesAgent : SalesUnit
{
	private int _credits;

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

public class SalesGroup : SalesUnit
{
	public SalesGroup()
	{
		Units =
			new
			System.Collections.Generic.List<SalesUnit>();
	}

	public System.Collections.Generic.IList<SalesUnit> Units { get; private set; }

	public override int GetCredit()
	{
		var credits = 0;

		foreach (var item in Units)
		{
			credits += item.GetCredit();
		}

		return credits;
	}

	public override void PayCommission(int amount)
	{
		var unitsCount = UnitsCount();

		var eachShare = amount / unitsCount;

		foreach (var salesUnit in Units)
		{
			salesUnit.PayCommission(eachShare);
		}
	}

	public override int UnitsCount()
	{
		var unitCount = 0;

		foreach (var item in Units)
		{
			unitCount += item.UnitsCount();
		}

		return unitCount;
	}
}
