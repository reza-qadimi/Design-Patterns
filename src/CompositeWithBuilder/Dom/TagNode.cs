using System.Text;

namespace CompositeWithBuilder.Dom;

public class TagNode : object
{
	public TagNode(string name) : base()
	{
		_name = name;
		_attributes = new();
		_value = string.Empty;
		_children = new System.Collections.Generic.List<TagNode>();
	}

	private string _value;
	public readonly string _name;
	private readonly System.Text.StringBuilder _attributes;
	private readonly System.Collections.Generic.IList<TagNode> _children;

	public void Add(TagNode node)
	{
		_children.Add(node);
	}

	public void AddAttribute(string attribute, string value)
	{
		_attributes.Append(" ");
		_attributes.Append(attribute);
		_attributes.Append("=");
		_attributes.Append(value);
		_attributes.Append("'");
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
		return Render(new StringBuilder()).ToString();
	}
}
