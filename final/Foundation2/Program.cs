using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
     var customers = new List<Customer>();

        
        var customer1 = new Customer("Megan Adams", new Address("26 Maple Lane", "Orem", "UT", "USA"));
        customers.Add(customer1);

        var customer2 = new Customer("Suzy Smith", new Address("101 SunFlower Lane", "Lancaster", "BC", "England"));
        customers.Add(customer2);

        
        var productsList1 = new List<Product>();
        productsList1.Add(new Product("Floral Purse", 101, 1, 25.00));
        productsList1.Add(new Product("Wedge Sandals", 102, 1, 18.95));
        productsList1.Add(new Product("Necklace", 103, 2, 10.50));

        
        var order1 = new Order(productsList1, customer1);
        double totalPrice1 = order1.CalculateTotalPrice();
        string packingLabel1 = order1.GetPackingLabel();
        string shippingLabel1 = order1.GetShippingLabel();

        Console.WriteLine("Total Price for Customer 1: $" + totalPrice1.ToString("F2"));
        Console.WriteLine(packingLabel1);
        Console.WriteLine(shippingLabel1);

        
        var productsList2 = new List<Product>();
        productsList2.Add(new Product("Sunglasses", 104, 1, 15.50));
        productsList2.Add(new Product("Purple Crocs", 105, 1, 30.25));
        productsList2.Add(new Product("Earrings", 106, 3, 5.50));

        
        var order2 = new Order(productsList2, customer2);
        double totalPrice2 = order2.CalculateTotalPrice();
        string packingLabel2 = order2.GetPackingLabel();
        string shippingLabel2 = order2.GetShippingLabel();

        Console.WriteLine("Total Price for Customer 2: $" + totalPrice2.ToString("F2"));
        Console.WriteLine(packingLabel2);
        Console.WriteLine(shippingLabel2);
    }

   

}