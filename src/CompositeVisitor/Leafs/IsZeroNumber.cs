namespace CompositeVisitor.Leafs;

public class IsZeroNumber : Composite.Specification<long>
{
	public static IsZeroNumber Create()
	{
		return new IsZeroNumber();
	}

	private IsZeroNumber() : base()
	{
	}

	public override bool IsSatisfiedBy(long target)
	{
		var result = target is 0;

		return result;
	}

	public override void Accept(Visitors.IVisitor visitor)
	{
		visitor.Visit(this);
	}
}
