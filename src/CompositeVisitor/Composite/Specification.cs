namespace CompositeVisitor.Composite;

public abstract class Specification<T> : object, ISpecification<T>
{
	public Specification() : base()
	{
	}

	public abstract bool IsSatisfiedBy(T target);

	public Specification<T> And(Specification<T> other)
	{
		var result =
			new AndSpecification<T>(left: this, right: other);

		return result;
	}

	public Specification<T> Or(Specification<T> other)
	{
		var result =
			new OrSpecification<T>(left: this, right: other);

		return result;
	}

	public Specification<T> Not()
	{
		var result =
			new NotSpecification<T>(this);

		return result;
	}

	public abstract void Accept(Visitors.IVisitor visitor);
}
