namespace CompositionVsInheritance.Composition;

public interface IXmlSerializer
{
	void Serialize(object value);
}

public class XmlSerializer : object, IXmlSerializer
{
	public XmlSerializer() : base()
	{
	}

	public void Serialize(object value)
	{
		System.Console.WriteLine(value: value.ToString());
	}
}

public class CompressingXmlSerializer : object, IXmlSerializer
{
	public CompressingXmlSerializer(IXmlSerializer serializer) : base()
	{
		Serializer = serializer;
	}

	public IXmlSerializer Serializer { get; }

	public void Serialize(object value)
	{
		Serializer.Serialize(value: value);
	}
}
