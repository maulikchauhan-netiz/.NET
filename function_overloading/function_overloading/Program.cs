using System;
public class cal
{
    public static int add(int a,int b)
    {
        return a + b;
    }
    public static float add(float a,float b)
    {
        return a + b;
    }
}
public class testmember
{
    public static void Main()
    {
        Console.WriteLine(cal.add(12, 22));
        Console.WriteLine(cal.add(12.4f, 22.3f));
    }
}