using System.Linq;

namespace IteratorComposite.Iterators;

public class FirstBreadthIterator : object, IIterator<Node>
{
	public FirstBreadthIterator(Node node) : base()
	{
		Items =
			new
			System.Collections.Generic.Queue<Node>();

		Items.Enqueue(node);
	}

	public Node? Item { get; private set; }

	private System.Collections.Generic.Queue<Node> Items { get; }

	public bool HasAny()
	{
		var result =
			Items.Any();

		return result;
	}

	public void MoveNext()
	{
		Item = Items.Dequeue();

		foreach (var item in Item.GetChildren())
		{
			Items.Enqueue(item: item);
		}
	}
}
