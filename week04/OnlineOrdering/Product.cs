public class Product
{
    private string _productName;
    private string _id;
    private decimal _price;
    private int _quantity;

    Product(string name, string id, decimal price, int quantity)
    {
        _productName = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // Calculates the total cost for the product based on price and quantity
    public decimal GetTotalCost()
    {
        decimal totalCost = _price * _quantity;
        return totalCost;
    }

    // Getter methods
    public string GetProductName()
    {
        return _productName;
    }
    public string GetID()
    {
        return _id;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}