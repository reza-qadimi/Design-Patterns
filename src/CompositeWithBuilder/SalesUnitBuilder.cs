namespace CompositeWithBuilder;

public class SalesUnitBuilder : ISalesUnitBuilder, ISalesUnitNameBuilder
{
	public static ISalesUnitBuilder Create(string rootGroupName)
	{
		var builder = new SalesUnitBuilder();

		return builder.Named(rootGroupName);
	}

	private SalesUnitBuilder() : base()
	{
		_root = null!;
	}

	private Sales.SalesGroup _root;

	public ISalesUnitBuilder Named(string name)
	{
		_root =
			new Sales.SalesGroup(name: name);

		return this;
	}
	public ISalesUnitBuilder WithAgent(string name)
	{
		var salesAgent =
			new Sales.SalesAgent(name: name);

		_root.AddChild(salesAgent);

		return this;
	}

	public ISalesUnitBuilder WithGroup
		(System.Action<ISalesUnitNameBuilder> builderConfig)
	{
		var builder = new SalesUnitBuilder();

		builderConfig.Invoke(builder);

		_root.AddChild(builder.Build());

		return this;
	}

	public Sales.SalesUnit Build()
	{
		return _root;
	}
}
