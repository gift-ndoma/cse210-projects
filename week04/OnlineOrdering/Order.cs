public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    private double GetShippingCost()
    {
        bool isInUsa = _customer.InUsa();
        double cost;

        if (isInUsa)
        {
            cost = 5;
        }
        else
        {
            cost = 35;
        }

        return cost;
    }
    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        return totalCost + GetShippingCost();
    }

    public string GetLabel()
    {
        string result = "";
        foreach (Product product in _products)
        {
            result += product.GetPackingLabel() + "\n";
        }
        return result.Trim();
    }

    public string GetShippingLabel()
    {
        return _customer.CreateShippingLabel();
    }
}