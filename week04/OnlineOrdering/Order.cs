public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        // Adds the products, their IDs, and quantities to the packing label
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductName()} (ID: {product.GetID()})";

            // Only adds quantity if more than 1
            if (product.GetQuantity() > 1)
            {
                packingLabel += $" x{product.GetQuantity()}";
            }

            packingLabel += "\n";
        }

        return packingLabel.TrimEnd('\n');
    }
    public string GetShippingLabel()
    {
        // Adds the customer's name and address to the shipping label
        string shippingLabel = $"{_customer.GetName()}\n{_customer.GetAddressString()}";
        return shippingLabel;
    }

    // Calculates the total price including shipping
    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0.0m;
        decimal shippingCost = 0.0m;

        // Totals the price of all products
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }

        // Determines the shipping cost based on the customer's country
        if (_customer.InUSA())
        {
            shippingCost = 5.0m;
        }
        else
        {
            shippingCost = 35.0m;
        }

        totalPrice += shippingCost;
        return totalPrice;
    }

    public void DisplayOrder()
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine($"\nTotal Price: {GetTotalPrice():C}");
        Console.WriteLine(new string('-', 30));
    }
}