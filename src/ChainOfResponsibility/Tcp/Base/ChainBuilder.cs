using System.Linq;

namespace ChainOfResponsibility.Tcp.Base
{
	public class ChainBuilder<T> : object
	{
		public ChainBuilder() : base()
		{
			Handlers =
				new System.Collections.Generic.List<IHandler<T>>();
		}

		private System.Collections.Generic.IList<IHandler<T>> Handlers { get; }

		public ChainBuilder<T>
			With<THandler>() where THandler : IHandler<T>, new()
		{
			var handler = new THandler();

			var result = With(handler);

			return result;
		}

		public ChainBuilder<T> With(IHandler<T> handler)
		{
			Handlers.Add(item: handler);

			return this;
		}

		public IHandler<T> Build()
		{
			Handlers.Aggregate((current, next) =>
			{
				current.SetSuccessor(next);

				return next;
			});

			return Handlers.First();
		}
	}
}
