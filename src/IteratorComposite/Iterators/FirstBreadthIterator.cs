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

	public Node? _item;

	public Node? Item
	{
		get
		{
			MoveNext();

			return _item;
		}
		set
		{
			_item = value;
		}
	}

	private System.Collections.Generic.Queue<Node> Items { get; }

	public bool HasAny()
	{
		var result =
			Items.Any();

		return result;
	}

	private void MoveNext()
	{
		_item = Items.Dequeue();

		foreach (var item in _item.GetChildren())
		{
			Items.Enqueue(item: item);
		}
	}
}
