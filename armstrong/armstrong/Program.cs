using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rem, temp, sum = 0;
            Console.Write("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.Write("number is armstrong");

            }
            else
            {
                Console.Write("number is not armstrong ");
            }


        }
    }
}
