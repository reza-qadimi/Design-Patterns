namespace Adapter.Logger;

public interface ILogger
{
	void Info(string message);

	void Warn(string message);

	void Fatal(string message);

	void Debug(string message);

	void Error(string message, System.Exception ex);
}

//public class NLogClassAdapter : NLog, ILogger
//{
//	// override NLog methods
//}

//public class NLogObjectAdapter : object, ILogger
//{
//	// public NLogObjectAdapter(NLog logger) : base() { }
//}
