using System.Security.Cryptography.X509Certificates;

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
    public double CalculateTotalPrice()
    {
        double totalCost = 0;
        foreach(Product product in _products)
        {
            totalCost+= product.GetTotalCost();
        }

        if(_customer.IsInUSA())
            totalCost+=5;
        else
            totalCost+=35;

        return totalCost;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label - Customer: {_customer.GetName()}. Address: {_customer.GetAddress()}";
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label\n";
        foreach(Product product in _products)
            packingLabel+= $"{product.GetNameAndProductId()}\n";
        return packingLabel;
    }

}