namespace CompositeSpecification.Composite;

public class NotSpecification<T> : Specification<T>
//public class NotSpecification<T> : object, ISpecification<T>
{
	public static NotSpecification<T> Create(ISpecification<T> target)
	{
		var instance =
			new
			NotSpecification<T>(target: target);

		return instance;
	}

	private NotSpecification(ISpecification<T> target) : base()
	{
		Target = target;
	}

	private ISpecification<T> Target { get; }

	public override bool IsSatisfiedBy(T target)
	{
		var result =
			Target.IsSatisfiedBy(target) == false;

		return result;
	}
}
