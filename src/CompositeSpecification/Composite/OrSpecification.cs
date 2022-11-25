namespace CompositeSpecification.Composite;

public class OrSpecification<T> : Specification<T>
//public class OrSpecification<T> : object, ISpecification<T>
{
	public static OrSpecification<T> Create(ISpecification<T> left, ISpecification<T> right)
	{
		var instance =
			new
			OrSpecification<T>(left: left, right: right);

		return instance;
	}

	private OrSpecification(ISpecification<T> left, ISpecification<T> right)
	{
		Left = left;
		Right = right;
	}

	private ISpecification<T> Left { get; }

	private ISpecification<T> Right { get; }

	public override bool IsSatisfiedBy(T target)
	{
		var result =
			Left.IsSatisfiedBy(target) || Right.IsSatisfiedBy(target);

		return result;
	}
}
