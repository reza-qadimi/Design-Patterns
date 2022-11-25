namespace Builder.Report;

public interface IReportBuilder
{
	void AddTitle(string title);

	void AddParagraph(string content);

	void AddFooter(string text);

	Document Build();
}
