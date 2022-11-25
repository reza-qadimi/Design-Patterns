namespace CompositeSpecification.Composite;

public abstract class Specification<T> : object, ISpecification<T>
{
	public Specification() : base()
	{
	}

	public abstract bool IsSatisfiedBy(T target);

	public Specification<T> Not()
	{
		var result =
			NotSpecification<T>
			.Create(target: this);

		return result;
	}

	public Specification<T> And(ISpecification<T> other)
	{
		var result =
			AndSpecification<T>
			.Create(left: this, right: other);

		return result;
	}

	public Specification<T> Or(ISpecification<T> other)
	{
		var result =
			OrSpecification<T>
			.Create(left: this, right: other);

		return result;
	}
}
