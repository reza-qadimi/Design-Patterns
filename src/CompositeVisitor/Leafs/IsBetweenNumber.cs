namespace CompositeVisitor.Leafs;

public class IsBetweenNumber : Composite.Specification<long>
{
	public static IsBetweenNumber Create(long start, long end)
	{
		var result =
			new IsBetweenNumber(start: start, end: end);

		return result;
	}

	private readonly long _end;
	private readonly long _start;

	private IsBetweenNumber(long start, long end) : base()
	{
		_end = end;
		_start = start;
	}

	public override bool IsSatisfiedBy(long target)
	{
		var result = target > _start && target < _end;

		return result;
	}

	public override void Accept(Visitors.IVisitor visitor)
	{
		visitor.Visit(this);
	}
}
