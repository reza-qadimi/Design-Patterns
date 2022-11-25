namespace CompositeSpecification.Leafs;

public class IsPositiveNumber : Composite.Specification<long>
{
	public static IsPositiveNumber Create()
	{
		return new IsPositiveNumber();
	}

	private IsPositiveNumber() : base()
	{
	}

	public override bool IsSatisfiedBy(long target)
	{
		var result = target is > 0;

		return result;
	}
}
