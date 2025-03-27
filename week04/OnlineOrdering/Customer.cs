public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string stateProvince, string country)
    {
        _name = name;
        _address = new Address(street, city, stateProvince, country);
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}