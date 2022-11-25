namespace Builder.UrlBuilder;

public class QueryParamsBuilder : object
{
	public QueryParamsBuilder() : base()
	{
		QueryParams =
			new
			System.Collections.Generic.Dictionary<string, string>();
	}

	private System.Collections.Generic.IDictionary<string, string> QueryParams { get; set; }

	public QueryParamsBuilder WithParams(string key, string value)
	{
		QueryParams.Add(key, value);

		return this;
	}

	public string Build()
	{
		string queryString = string.Empty;


		foreach (var item in QueryParams)
		{
			queryString += $"?{item.Key}={item.Value}";
		}

		return queryString;
	}
}
