using System.Linq;

namespace IteratorComposite;

public class Node : object
{
	public Node(string name) : base()
	{
		Name = name;

		SubNodes =
			new
			System.Collections.Generic.List<Node>();
	}

	public string Name { get; private set; }

	private System.Collections.Generic.List<Node> SubNodes { get; }

	public void Add(Node node)
	{
		SubNodes.Add(item: node);
	}

	public void Add(params Node[] nodes)
	{
		SubNodes.AddRange(collection: nodes);
	}

	public void ForEach(System.Action<Node> action)
	{
		var iterator = CreateIterator();

		while(iterator.HasAny())
		{
			iterator.MoveNext();

			var node = iterator.Item;

			action(node);
		}
	}

	public System.Collections.Generic.IReadOnlyList<Node> GetChildren() => SubNodes.AsReadOnly();

	public bool HasChildren() => SubNodes.Any();

	public Iterators.IIterator<Node> CreateIterator()
	{
		var result =
			new Iterators.FirstBreadthIterator(this);

		return result;
	}
}
