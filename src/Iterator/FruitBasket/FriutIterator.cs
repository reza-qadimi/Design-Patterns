namespace Iterator.FruitBasket;

public class FriutIterator : object, IIterator<string>
{
	public FriutIterator(System.Collections.Generic.IList<string> fruits) : base()
	{
		_fruits = fruits;
	}

	private int _index;

	private readonly System.Collections.Generic.IList<string> _fruits;

	public string Item
	{
		get
		{
			var result = _fruits[_index];

			return result;
		}
	}

	public bool IsDone()
	{
		var result =
			_index == _fruits.Count;

		return result;
	}

	public void MoveNext()
	{
		_index++;
	}
}
