using System;
using System.Collections.Generic;

class Product
{
    private string productName;
    private double productID;
    private double quantity;
    private double price;

    public Product(string _productName, double _productID, double _quantity, double _price)
    {
        productName = _productName;
        productID = _productID;
        quantity = _quantity;
        price = _price;
    }

    public double CalculatePrice()
    {
        return quantity * price;
    }

    public string GetProductName()
    {
        return productName;
    }

    public double GetProductId()
    {
        return productID;
    }

    public double GetQuantity()
    {
        return quantity;
    }

    
}