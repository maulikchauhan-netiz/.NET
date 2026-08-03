using System;

public delegate int calc(int n);
class program
{
    static int number = 100;
    public static int add (int n)
    {
        number= number+n;
        return number;
    }
    public static int mul(int n)
    {
        number = number*n;
        return number;
    }
    public static int getnumber()
    {
        return number;
    }
    public static void Main(string[] args)
    {
        calc c1 = new calc(add);
        calc c2 = new calc(mul);
        c1(20);
        Console.WriteLine("after delegate : "+getnumber());
        c1(3);
        Console.WriteLine("after delegate : " +getnumber());
    }
}


