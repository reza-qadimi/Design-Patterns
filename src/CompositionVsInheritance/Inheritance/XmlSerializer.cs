namespace CompositionVsInheritance.Inheritance;

public abstract class XmlSerializer : object
{
	public XmlSerializer() : base()
	{
	}

	public virtual void Serialize(object value)
	{
		System.Console.WriteLine(value: value.ToString());
	}
}

public class FastXmlSerializer : XmlSerializer
{
	public FastXmlSerializer() : base()
	{
	}

	public override void Serialize(object value)
	{
		base.Serialize(value: value);
	}
}

public class CompressingXmlSerializer : XmlSerializer
{
	public CompressingXmlSerializer() : base()
	{
	}

	public override void Serialize(object value)
	{
		base.Serialize(value: value);
	}
}
