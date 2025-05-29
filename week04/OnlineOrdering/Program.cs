using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Alarere", "Ibadan", "Oyo State", "Nigeria");
        Customer customer1 = new Customer("Gift Ndoma", address1);
        Product product1 = new Product("Women Jewelry Set", "WO34KH4", 22.4, 4);
        Product product2 = new Product("Men's Jewelry Set", "M34J8d", 28.4, 2);
        Product product3 = new Product("Children Jewelry Set", "WO34KH4", 15.4, 3);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        string label1 = order1.GetLabel();
        double shoppingCost1 = order1.CalculateTotalCost();
        string shipLabel1 = order1.GetShippingLabel();
        Console.WriteLine($"Packing Label: {label1}");
        Console.WriteLine($"Shipping Label: {shipLabel1}");
        Console.WriteLine($"Total Price: {shoppingCost1}");
        Console.WriteLine();


        Address address2 = new Address("Dublin", "Ohio", "Denmark", "USA");
        Customer customer2 = new Customer("Choice Ndoma", address2);
        Product product4 = new Product("Women Jewelry Set", "WO34KH4", 22.4, 4);
        Product product5 = new Product("Men's Jewelry Set", "M34J8d", 28.4, 2);
        Product product6 = new Product("Children Jewelry Set", "WO34KH4", 15.4, 3);
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        string label2 = order2.GetLabel();
        double shoppingCost2 = order2.CalculateTotalCost();
        string shipLabel2 = order2.GetShippingLabel();
        Console.WriteLine($"Packing Label: {label2}");
        Console.WriteLine($"Shipping Label: {shipLabel2}");
        Console.WriteLine($"Total Price: {shoppingCost2}");

       


    }
}