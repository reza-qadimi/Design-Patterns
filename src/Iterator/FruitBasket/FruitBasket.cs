namespace Iterator.FruitBasket;

public class FruitBasket : object, IBasket<string>
{
	private System.Collections.Generic.IList<string> _fruits;

	public FruitBasket() : base()
	{
		_fruits = new System.Collections.Generic.List<string>()
		{
			"Apple",
			"Orange",
			"Bannana",
		};
	}

	public IIterator<string> CreateIterator => new FriutIterator(fruits:_fruits);
}
