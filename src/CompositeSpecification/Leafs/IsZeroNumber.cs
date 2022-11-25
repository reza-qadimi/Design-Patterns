namespace CompositeSpecification.Leafs;

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
}
