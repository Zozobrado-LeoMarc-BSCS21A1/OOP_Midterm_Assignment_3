using ClassLibrary1;

namespace TestProject1;

public class Customer
{

    private List<Order> _orders = new List<Order>();

    public Customer()
    {
        
    }

    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }

    public Order[] GetOrders()
    {

        return _orders.ToArray();

    }


}
