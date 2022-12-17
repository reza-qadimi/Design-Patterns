namespace CompositeVisitor.Composite;

public class OrSpecification<T> : Specification<T>
{
	public OrSpecification
		(Specification<T> left, Specification<T> right)
	{
		Left = left;
		Right = right;
	}

	public Specification<T> Left { get; }

	public Specification<T> Right { get; }

	public override bool IsSatisfiedBy(T target)
	{
		var result =
			Left.IsSatisfiedBy(target) || Right.IsSatisfiedBy(target);

		return result;
	}

	public override void Accept(Visitors.IVisitor visitor)
	{
		visitor.Visit(this);
	}
}
