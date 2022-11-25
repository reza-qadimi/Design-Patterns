namespace Builder.Report;

public class HtmlDocumentBuilder
{
	public HtmlDocumentBuilder() : base()
	{
	}

	public HtmlDocumentBuilder AddHeader(string header)
	{
		return this;
	}

	public HtmlDocumentBuilder AddParagraph(string paragraph)
	{
		return this;
	}

	public HtmlDocumentBuilder AddTable(string content)
	{
		return this;
	}

	public string Build()
	{
		return string.Empty;
	}
}
