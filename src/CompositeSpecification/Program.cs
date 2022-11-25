namespace CompositeSpecification;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		bool result;

		var condition =
			Leafs.IsBetweenNumber.Create(start: 1, end: 10);

		result = condition.IsSatisfiedBy(target: 11);

		System.Console.WriteLine(value: result);

		result = condition.IsSatisfiedBy(8);

		System.Console.WriteLine(value: result);
	}
}
