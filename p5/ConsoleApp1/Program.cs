using System;

namespace p5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, rev = "";

            Console.Write("Enter String: ");
            str = Console.ReadLine();

            int l = str.Length - 1;

            for (int i = l; i >= 0; i--)
            {
                rev = rev + str[i];
            }

            if (rev == str)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }

            Console.ReadKey();
        }
    }
}