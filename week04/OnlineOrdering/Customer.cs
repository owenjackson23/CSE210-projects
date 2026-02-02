public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InUSA()
    {

        return _address.InUSA();
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddressString()
    {
        return _address.GetAddressString();
    }
}