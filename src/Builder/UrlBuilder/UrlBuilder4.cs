namespace Builder.UrlBuilder;

public class UrlBuilder4 : object
{
	public UrlBuilder4() : base()
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

	// Delegate | Function Builder
	public void WithQueryParam(System.Action<QueryParamsBuilder> builderConfiguration)
	{
		builderConfiguration.Invoke(QueryParams);
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
