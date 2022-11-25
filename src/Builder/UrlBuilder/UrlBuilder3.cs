namespace Builder.UrlBuilder;

public class UrlBuilder3 : object
{
	public UrlBuilder3() : base()
	{
		Scheme = "https";

		QueryParams =
			new
			QueryParamsBuilder();
	}

	private string? Port { get; set; }

	private string? Host { get; set; }

	private string? Scheme { get; set; }

	private QueryParamsBuilder QueryParams { get; set; }

	public void WithPort(int port)
	{
		Port = $":{port}";
	}

	public void WithScheme(string scheme)
	{
		Scheme = scheme;
	}

	public void WithQueryParam(QueryParamsBuilder queryParamsBuilder)
	{
		QueryParams = queryParamsBuilder;
	}

	public void WithHost(string host)
	{
		Host = host;
	}

	public string Build()
	{
		var url = $"{Scheme}://{Host}{Port}/{QueryParams.Build()}";

		return url;
	}
}
