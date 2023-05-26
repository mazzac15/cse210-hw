using System;
using System.Collections.Generic;

class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string _streetAddress, string _city, string _state, string _country)
    {
        streetAddress = _streetAddress;
        city = _city;
        state = _state;
        country = _country;

    }

    public string GetFullAddress()
    {
        return $"{streetAddress}\n{city}, {state}\n{country}";
    }

    public string GetCountry()
    {
        return country;

    }
    
}