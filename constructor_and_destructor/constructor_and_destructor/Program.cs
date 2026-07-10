using System;

public class ResourceManager
{
    public ResourceManager()
    {
        Console.WriteLine("resources initialized constructor invoked");
    }
    ~ResourceManager()
    {
        Console.WriteLine("resources released(destructor invoked");
        Console.ReadKey();


    }
}
class Test
{
    public static void Main(string[]args)
    {
        ResourceManager rm = new ResourceManager();
      
    }
}
    