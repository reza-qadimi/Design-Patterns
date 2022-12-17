namespace CompositeVisitor.Composite;

public interface ISpecification<T>
{
	bool IsSatisfiedBy(T target);
}
