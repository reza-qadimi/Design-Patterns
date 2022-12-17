namespace CompositeVisitor.Composite;

public interface ISpecification<T>
{
	bool IsSatisfied(T target);
}

public abstract class Specification<T> : object, ISpecification<T>
{
	public Specification() : base()
	{
	}

	public abstract bool IsSatisfied(T target);

	public Specification<T> And(Specification<T> other)
	{
		var result =
			new AndSpecification<T>(left: this, right: other);

		return result;
	}
}

public class AndSpecification<T> : Specification<T>
{
	public AndSpecification
		(Specification<T> left, Specification<T> right)
	{
		Left = left;
		Right = right;
	}

	public Specification<T> Left { get; }

	public Specification<T> Right { get; }

	public override bool IsSatisfied(T target)
	{
		var result =
			Left.IsSatisfied(target) && Right.IsSatisfied(target);

		return result;
	}
}
