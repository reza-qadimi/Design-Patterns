namespace Builder.HttpRequest;

public interface IHttpRequestContentBuilder
{
	IHttpRequestContentBuilder WithBody(string body);
}
