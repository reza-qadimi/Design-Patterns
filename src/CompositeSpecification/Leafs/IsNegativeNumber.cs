namespace CompositeSpecification.Leafs;

public class IsNegativeNumber : Composite.Specification<long>
{
	public static IsNegativeNumber Create()
	{
		return new IsNegativeNumber();
	}

	private IsNegativeNumber() : base()
	{
	}

	public override bool IsSatisfiedBy(long target)
	{
		var result = target is < 0;

		return result;
	}
}
