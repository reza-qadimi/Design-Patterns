namespace Builder.UrlBuilder;

public class UrlBuilder1 : object
{
	public UrlBuilder1() : base()
	{
		Scheme = "https";
	}

	private string? Port { get; set; }

	private string? Host { get; set; }

	private string? Scheme { get; set; }

	private string? QueryString { get; set; }

	public void WithPort(int port)
	{
		Port = $":{port}";
	}

	public void WithScheme(string scheme)
	{
		Scheme = scheme;
	}

	public void WithQueryString(string queryString)
	{
		QueryString = queryString;
	}

	public void WithHost(string host)
	{
		Host = host;
	}

	public string Build()
	{
		var url = $"{Scheme}://{Host}{Port}/{QueryString}";

		return url;
	}
}
