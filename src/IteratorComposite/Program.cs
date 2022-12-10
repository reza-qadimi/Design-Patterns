var root = new IteratorComposite.Node("Root");
var node1 = new IteratorComposite.Node("Node1");
var node2 = new IteratorComposite.Node("Node2");
var node3 = new IteratorComposite.Node("Node3");
var node4 = new IteratorComposite.Node("Node4");
var node5 = new IteratorComposite.Node("Node5");
var node6 = new IteratorComposite.Node("Node6");
var node7 = new IteratorComposite.Node("Node7");

root.Add(node1, node2, node3);
node1.Add(node4, node5);
node2.Add(node7);
node5.Add(node6);

root.ForEach(current => System.Console.WriteLine(value: current.Name));

var iterator = root.CreateIterator();

while (iterator.HasAny())
{
	//iterator.MoveNext();

	var node = iterator.Item;

	if (node != null)
	{
		System.Console.WriteLine(value: node.Name);
	}
}
