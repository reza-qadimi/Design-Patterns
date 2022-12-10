namespace Iterator.FruitBasket;

public interface IBasket<T>
{
	IIterator<T> CreateIterator { get; }
}
