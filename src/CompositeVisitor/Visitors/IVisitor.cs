namespace CompositeVisitor.Visitors;

public interface IVisitor
{
	void Visit<T>(Composite.AndSpecification<T> specification);

	void Visit<T>(Composite.OrSpecification<T> specification);

	void Visit<T>(Composite.NotSpecification<T> specification);

	void Visit(Leafs.IsZeroNumber specification);

	void Visit(Leafs.IsBetweenNumber specification);

	void Visit(Leafs.IsNegativeNumber specification);

	void Visit(Leafs.IsPositiveNumber specification);
}
