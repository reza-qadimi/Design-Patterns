namespace Builder.HttpRequest;

public static class HttpRequestFactory
{
	public static IHttpRequestMethodBuilder NewRequest()
	{
		return new HttpRequestBuilder();
	}
}
