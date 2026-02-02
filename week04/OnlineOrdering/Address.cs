public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Checks if the address is in the USA
    public bool InUSA()
    {
        string country = _country.ToLower();
        if (country == "usa" || country == "united states" || country == "united states of america")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Returns the address as a string
    public string GetAddressString()
    {
        string addressString = "";
        if (_state == "")
        {
            addressString = $"{_street}\n{_city}\n{_country}";
        }
        else
        {
            addressString = $"{_street}\n{_city}, {_state}\n{_country}";
        }
        return addressString;
    }
}