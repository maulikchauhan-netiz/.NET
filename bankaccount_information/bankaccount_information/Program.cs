using System;

class bankaccount
{
    private double balance;

    public double b1
    {
        get
        {
            return balance;

        }
        set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("invalid amount");
            }
        }
    }
}
class test
{
    static void Main(string[] args)
    {
        bankaccount e1 = new bankaccount();
        e1.b1 = 0.0;
        Console.WriteLine("employee name is : " + e1.b1);
    }
}