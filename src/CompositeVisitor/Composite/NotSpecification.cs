namespace CompositeVisitor.Composite;

public class NotSpecification<T> : Specification<T>
{
	public NotSpecification(Specification<T> target)
	{
		Target = target;
	}

	public Specification<T> Target { get; }

	public override bool IsSatisfiedBy(T target)
	{
		var result =
			Target.IsSatisfiedBy(target) == false;

		return result;
	}

	public override void Accept(Visitors.IVisitor visitor)
	{
		visitor.Visit(this);
	}
}
