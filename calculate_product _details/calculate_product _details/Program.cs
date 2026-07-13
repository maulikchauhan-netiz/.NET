using System;
using System.Data;
public class calculate_product_details
{
    public string prodName;
    public double prodprice;
    public int prodquantity;

    public calculate_product_details(string name,double price,int quantity)
    {
        prodName = name;
        prodprice = price;
        prodquantity = quantity;
    }
    public void Display()
    {
        double totalbill=prodprice*prodquantity;
        Console.WriteLine("product name : " + prodName);
        Console.WriteLine("price : " + prodprice);
        Console.WriteLine("quantity : " + prodquantity);
        Console.WriteLine("total bill : " + totalbill);
        Console.WriteLine("==============================");

    }
}
class test
{
    public static void Main(string[]args)
    {
        Console.WriteLine("=========product details========");
        calculate_product_details p1 = new calculate_product_details("laptop", 450000, 1);
        p1.Display();
    }
}