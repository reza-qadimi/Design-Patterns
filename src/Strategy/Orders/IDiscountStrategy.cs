namespace Strategy.Orders;

public interface IDiscountStrategy
{
	decimal Calculate(decimal totalPrice);
}
