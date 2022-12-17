namespace CompositeWithBuilder;

public interface ISalesUnitNameBuilder
{
	ISalesUnitBuilder Named(string name);
}

public interface ISalesUnitBuilder
{
	Sales.SalesUnit Build();
	ISalesUnitBuilder WithAgent(string agentName);
	ISalesUnitBuilder WithGroup(System.Action<ISalesUnitNameBuilder> builderConfig);
}
