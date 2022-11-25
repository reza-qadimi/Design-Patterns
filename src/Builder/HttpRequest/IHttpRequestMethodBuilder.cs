namespace Builder.HttpRequest;

public interface IHttpRequestMethodBuilder
{
	IHttpRequestBuilder Get();
	IHttpRequestContentBuilder Post();
	IHttpRequestContentBuilder Put();
}
