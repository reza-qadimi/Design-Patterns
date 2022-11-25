namespace Builder.Report;

public class HtmlReportBuilder : IReportBuilder
{
	public HtmlReportBuilder() : base()
	{
	}

	public void AddParagraph(string content)
	{
		throw new System.NotImplementedException();
	}

	public void AddTitle(string title)
	{
		throw new System.NotImplementedException();
	}

	public void AddFooter(string text)
	{
		throw new System.NotImplementedException();
	}

	public Document Build()
	{
		return new HtmlDocument();
	}
}
