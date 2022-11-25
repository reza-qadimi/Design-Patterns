namespace CompositeWithBuilder.Dom;

public class AttributeBuilder : object
{
	public AttributeBuilder() : base()
	{
		Attributes =
			new
			System.Collections.Generic.Dictionary<string, string>();
	}


	public AttributeBuilder WithAttribute(string key, string value)
	{
		Attributes.Add(key, value);

		return this;
	}

	private System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

	public System.Text.StringBuilder Build()
	{
		var resultString =
			new System.Text.StringBuilder();

		foreach (var item in Attributes)
		{
			var value =
				$" {item.Key}='{item.Value}'";

			resultString.Append(value: value);
		}

		return resultString;
	}
}
