public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

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
    public string GetAddressString()
    {
        string addressString = $"{_street}\n{_city}, {_state}\n{_country}";
        return addressString;
    }
}