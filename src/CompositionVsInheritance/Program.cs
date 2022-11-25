namespace CompositionVsInheritance;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		var user = new
		{
			FirstName = "Reza",
			LastName = "Qadimi",
			EmailAddress = "RezaQadimi.ir@Gmail.com",
		};

		var serializer =
			new
			Composition.XmlSerializer();

		var serializingAlgorithm =
			new
			Composition.CompressingXmlSerializer(serializer: serializer);

		serializingAlgorithm.Serialize(value: user);
	}
}
