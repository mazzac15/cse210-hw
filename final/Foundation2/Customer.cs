using System;
using System.Collections.Generic;

class Customer
{
    private string customerName;

    private Address customerAddress;


    public Customer(string _customerName, Address _customerAddress)
    {
        customerName =_customerName;
        customerAddress = _customerAddress;
    }
    public string GetCustomerName()
    {
        return customerName;
    }

    public string GetCustomerAddress()
    {
        return customerAddress.GetFullAddress();
    }

    public string GetCountry()
    {
        return customerAddress.GetCountry();
    }
}
