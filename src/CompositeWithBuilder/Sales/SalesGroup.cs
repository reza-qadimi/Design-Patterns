namespace CompositeWithBuilder.Sales;

public class SalesGroup : SalesUnit
{
	public SalesGroup(string name) : base(name)
	{
		Children =
			new
			System.Collections.Generic.List<SalesUnit>();
	}

	public System.Collections.Generic.IList<SalesUnit> Children { get; private set; }

	public SalesGroup AddChild(SalesUnit unit)
	{
		Children.Add(unit);

		return this;
	}

	public override int GetCredit()
	{
		var credits = 0;

		foreach (var item in Children)
		{
			credits += item.GetCredit();
		}

		return credits;
	}

	public override void PayCommission(int amount)
	{
		var unitsCount = UnitsCount();

		var eachShare = amount / unitsCount;

		foreach (var salesUnit in Children)
		{
			salesUnit.PayCommission(eachShare);
		}
	}

	public override int UnitsCount()
	{
		var unitCount = 0;

		foreach (var item in Children)
		{
			unitCount += item.UnitsCount();
		}

		return unitCount;
	}
}
