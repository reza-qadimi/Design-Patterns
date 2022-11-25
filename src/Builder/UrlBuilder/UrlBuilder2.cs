namespace Builder.UrlBuilder;

public class UrlBuilder2 : object
{
	public UrlBuilder2() : base()
	{
		Scheme = "https";

		QueryParams =
			new
			System.Collections.Generic.Dictionary<string, string>();
	}

	private string? Port { get; set; }

	private string? Host { get; set; }

	private string? Scheme { get; set; }

	private System.Collections.Generic.IDictionary<string, string> QueryParams { get; set; }

	public void WithPort(int port)
	{
		Port = $":{port}";
	}

	public void WithScheme(string scheme)
	{
		Scheme = scheme;
	}

	public void WithQueryParam(string key, string value)
	{
		QueryParams.Add(key, value);
	}

	public void WithHost(string host)
	{
		Host = host;
	}

	public string Build()
	{
		string queryString = string.Empty;


		foreach (var item in QueryParams)
		{
			queryString += $"?{item.Key}={item.Value}";
		}

		var url = $"{Scheme}://{Host}{Port}/{queryString}";

		return url;
	}
}
