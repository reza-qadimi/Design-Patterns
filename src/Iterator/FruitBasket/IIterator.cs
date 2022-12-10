namespace Iterator.FruitBasket;

public interface IIterator<T>
{
	bool IsDone();

	void MoveNext();

	T Item { get; }
}
