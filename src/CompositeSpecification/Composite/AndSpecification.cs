namespace CompositeSpecification.Composite;

public class AndSpecification<T> : Specification<T>
//public class AndSpecification<T> : object, ISpecification<T>
{
	public static AndSpecification<T> Create(ISpecification<T> left, ISpecification<T> right)
	{
		var instance =
			new
			AndSpecification<T>(left: left, right: right);

		return instance;
	}

	private AndSpecification(ISpecification<T> left, ISpecification<T> right)
	{
		Left = left;
		Right = right;
	}

	private ISpecification<T> Left { get; }

	private ISpecification<T> Right { get; }

	public override bool IsSatisfiedBy(T target)
	{
		var result =
			Left.IsSatisfiedBy(target) && Right.IsSatisfiedBy(target);

		return result;
	}
}
