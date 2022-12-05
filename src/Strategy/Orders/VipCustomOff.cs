namespace Strategy.Orders;

public class VipCustomOff : object, IDiscountStrategy
{
	public static IDiscountStrategy Instance => new VipCustomOff();

	private VipCustomOff() : base()
	{
	}

	public decimal Calculate(decimal totalPrice)
	{
		var discount =
			totalPrice * 0.05M;

		return discount;
	}
}
