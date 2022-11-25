namespace CompositeWithBuilder.Dom;

public class TagNode : object
{
	public static TagNode Create(string name)
	{
		var tagNode =
			new TagNode(name: name);

		return tagNode;
	}
	private TagNode(string name) : base()
	{
		_name = name;
		_attributes = new();
		_value = string.Empty;
		_attributeBuilder = new AttributeBuilder();
		_children = new System.Collections.Generic.List<TagNode>();
	}

	private string _value;
	public readonly string _name;
	private AttributeBuilder _attributeBuilder { get; set; }
	private System.Text.StringBuilder _attributes { get; set; }
	private System.Collections.Generic.IList<TagNode> _children;

	public void Add(TagNode node)
	{
		_children.Add(node);
	}

	public void AddAttribute(string attribute, string value)
	{
		_attributes.Append(" ");
		_attributes.Append(attribute);
		_attributes.Append("=");
		_attributes.Append("'");
		_attributes.Append(value);
		_attributes.Append("'");
	}

	public void WithAttribute(System.Action<AttributeBuilder> attribute)
	{
		attribute.Invoke(_attributeBuilder);

		_attributes = _attributeBuilder.Build();
	}

	public void AddValue(string value)
	{
		_value = value;
	}

	private System.Text.StringBuilder Render(System.Text.StringBuilder resultBuilder)
	{
		resultBuilder.Append($"<{_name} {_attributes}>");

		foreach (var tagNode in _children)
		{
			tagNode.Render(resultBuilder);
		}

		resultBuilder.Append($"{_value}");
		resultBuilder.Append($"</{_name}>");

		return resultBuilder;
	}
	public string Render()
	{
		var resultBuilder =
			new System.Text.StringBuilder();

		var result =
			Render(resultBuilder: resultBuilder)
			.ToString();

		return result;
	}
}
