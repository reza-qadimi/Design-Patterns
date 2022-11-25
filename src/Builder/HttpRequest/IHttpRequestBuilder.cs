namespace Builder.HttpRequest;

public interface IHttpRequestBuilder
{
	IHttpRequestBuilder SetUrl(string url);

	System.Net.Http.HttpRequestMessage Build();
}
