namespace CompositeWithBuilder.Dom;

public class XmlDocumentBuilder : object
{
	public static XmlDocumentBuilder CreateNode(string rootNode)
	{
		var xmlDocumentBuild =
			new XmlDocumentBuilder(rootNode: rootNode);

		return xmlDocumentBuild;
	}

	private XmlDocumentBuilder(string rootNode) : base()
	{
		RootNode =
			TagNode.Create(name: rootNode);

		CurrentNode = RootNode;
	}

	public TagNode? RootNode { get; }

	public TagNode? CurrentNode { get; private set; }

	public TagNode? ParentNode { get; private set; }

	public XmlDocumentBuilder AddChild(string name)
	{
		var child =
			TagNode.Create(name: name);

		if (CurrentNode != null)
		{
			CurrentNode.Add(child);
		}

		ParentNode = CurrentNode;

		CurrentNode = child;



		return this;
	}

	public XmlDocumentBuilder AddSibling(string name)
	{
		var sibling =
			TagNode.Create(name: name);

		if (ParentNode != null)
		{
			ParentNode.Add(node: sibling);
		}

		CurrentNode = sibling;

		return this;
	}

	public XmlDocumentBuilder WithAttribute(string key, string value)
	{
		if (CurrentNode != null)
		{
			CurrentNode.AddAttribute(attribute: key, value: value);
		}

		return this;
	}

	public XmlDocumentBuilder WithAttribute(System.Action<AttributeBuilder> attribute)
	{
		if (CurrentNode != null)
		{
			CurrentNode.WithAttribute(attribute);
		}

		return this;
	}

	public TagNode? Build()
	{
		return RootNode;
	}
}
