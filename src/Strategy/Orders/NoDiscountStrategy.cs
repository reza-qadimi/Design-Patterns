namespace Strategy.Orders;

public class NoDiscountStrategy : object, IDiscountStrategy
{
	public static IDiscountStrategy Instance => new NoDiscountStrategy();

	private NoDiscountStrategy() : base()
	{
	}

	public decimal Calculate(decimal totalPrice)
	{
		var discount = 0;

		return discount;
	}
}
