namespace CompositeWithBuilder.Sales;

public class SalesGroup : SalesUnit
{
	public SalesGroup()
	{
		Units =
			new
			System.Collections.Generic.List<SalesUnit>();
	}

	public System.Collections.Generic.IList<SalesUnit> Units { get; private set; }

	public SalesGroup AddUnit(SalesUnit unit)
	{
		Units.Add(unit);

		return this;
	}

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
