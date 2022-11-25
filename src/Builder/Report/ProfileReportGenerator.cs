namespace Builder.Report;

public class ProfileReportGenerator : object
{
	public ProfileReportGenerator(IReportBuilder builder) : base()
	{
		Builder = builder;
	}

	private IReportBuilder Builder { get; }

	public void Parse(string filePath)
	{
		Builder.AddTitle("title");
		Builder.AddParagraph("paragraph1");
		Builder.AddParagraph("paragraph2");
		Builder.AddFooter("footer");
	}
}
