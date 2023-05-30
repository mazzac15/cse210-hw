using System;

class Address
{
    private string streetAddress;
    private string city;
    private string state;

    public Address(string _streetAddress, string _city, string _state)
    {
        streetAddress = _streetAddress;
        city = _city;
        state = _state;
    }
    public string GetFullEventAddress()
    {
        return $"{streetAddress}\n{city}, {state}";
    }
}