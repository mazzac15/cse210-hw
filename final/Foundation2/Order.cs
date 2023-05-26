using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customerOrder;
    
    public Order(List<Product> _products, Customer _customerOrder)
    {
        customerOrder = _customerOrder;
        products = _products;
        
    }

    public double CalculateTotalPrice()
    {
        double totalCost = 0;
        foreach(Product product in products)
        {
            totalCost += product.CalculatePrice();
        }

        if (customerOrder.GetCountry() == "USA")
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return Math.Round(totalCost, 2);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"Product ID: {product.GetProductId()} Quantity: {product.GetQuantity()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping Label:\n{customerOrder.GetCustomerName()}\n{customerOrder.GetCustomerAddress()}\n";
        return shippingLabel;
    }

}