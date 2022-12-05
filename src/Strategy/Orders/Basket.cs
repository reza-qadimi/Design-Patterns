namespace Strategy.Orders;

public class Basket : object
{
	public static Basket Instance
		(decimal totalPrice) => new(totalPrice: totalPrice);

	private Basket(decimal totalPrice) : base()
	{
		TotalPrice = totalPrice;
		CreateDateTime = System.DateTime.Now;
	}

	public System.DateTime CreateDateTime { get; private set; }

	public decimal TotalPrice { get; private set; }

	public void ApplyDiscount()
	{
		ApplyDiscount(strategy: NoDiscountStrategy.Instance);
	}

	public void ApplyDiscount(IDiscountStrategy strategy)
	{
		TotalPrice -= strategy.Calculate(totalPrice: TotalPrice);
	}
}
