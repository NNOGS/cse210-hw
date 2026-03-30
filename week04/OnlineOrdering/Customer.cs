using System;

public class Customer
{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if customer is in USA
    public bool IsInUSA()
    {
        return _address.IsInUSA(); // assigns to the address class
    }

    // Method to get customer's name
    public string GetName()
    {
        return _name;
    }

    //Method to get full address for shipping
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}