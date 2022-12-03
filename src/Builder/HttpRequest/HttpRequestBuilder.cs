namespace Builder.HttpRequest;

// Sample: Fluent Migrator -> Using Step Builders

//public class HttpRequestBuilder : IHttpRequestBuilder,
//	IHttpRequestMethodBuilder, IHttpRequestContentBuilder
internal class HttpRequestBuilder : IHttpRequestBuilder,
	IHttpRequestMethodBuilder, IHttpRequestContentBuilder
{
	//public static IHttpRequestBuilder Create()
	//{
	//	return new HttpRequestBuilder();
	//}

	public HttpRequestBuilder() : base()
	{
	}

	//private HttpRequestBuilder() : base()
	//{
	//}

	public string Url { get; private set; } = string.Empty;
	public string Content { get; private set; } = string.Empty;
	public System.Net.Http.HttpMethod Method { get; private set; } = System.Net.Http.HttpMethod.Get;


	public System.Net.Http.HttpRequestMessage Build()
	{
		var requestMessage = new System.Net.Http.HttpRequestMessage()
		{
			Method = Method,
			RequestUri = new System.Uri(uriString: Url),
		};

		return requestMessage;
	}

	public IHttpRequestBuilder Get()
	{
		Method = System.Net.Http.HttpMethod.Get;
		return this;
	}

	public IHttpRequestContentBuilder Post()
	{
		Method = System.Net.Http.HttpMethod.Post;
		return this;
	}

	public IHttpRequestContentBuilder Put()
	{
		Method = System.Net.Http.HttpMethod.Put;
		return this;
	}

	public IHttpRequestBuilder SetUrl(string url)
	{
		Url = url;

		return this;
	}

	public IHttpRequestContentBuilder WithBody(string body)
	{
		Content = body;

		return this;
	}
}
