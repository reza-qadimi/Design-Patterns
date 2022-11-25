namespace CompositeSpecification.Leafs;

public class IsBetweenNumber : Composite.Specification<int>
{
	public static IsBetweenNumber Create(int start, int end)
	{
		var result =
			new IsBetweenNumber(start: start, end: end);

		return result;
	}

	private readonly int _end;
	private readonly int _start;

	private IsBetweenNumber(int start, int end) : base()
	{
		_end = end;
		_start = start;
	}

	public override bool IsSatisfiedBy(int target)
	{
		var result = target > _start && target < _end;

		return result;
	}
}
