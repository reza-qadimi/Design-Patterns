using Iterator.FruitBasket;

var basket = new FruitBasket();


var iterator = basket.CreateIterator;

while (iterator.IsDone() == false)
{
	var currentItem = iterator.Item;

	System.Console.WriteLine(value: currentItem);

	iterator.MoveNext();
}
