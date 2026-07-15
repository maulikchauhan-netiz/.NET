using System;

public interface IOrderservices
{
    void ProcessOrder();
}
public class standradDelevery : IOrderservices
{
    public void ProcessOrder()
    {
        Console.Write("enter the item name for standard delevery : ");
        string item = Console.ReadLine();
        Console.WriteLine("order placed for the product" +  item + "and express delivery will arrive today");
    }
}
public class ExpressDelevery : IOrderservices
{
    public void ProcessOrder()
    {
        Console.Write("enter the item name for Express delevery : ");
        string item = Console.ReadLine();
        Console.WriteLine("order placed for the product" + item + "and express delivery will arrive today");
    }
}
class program
{
    static void Main(string[] args)
    {
        standradDelevery services = new standradDelevery();
        services.ProcessOrder();

        ExpressDelevery service = new ExpressDelevery();
        service.ProcessOrder();
    }
}