using System;

namespace Anagram_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first String: ");
            String s1 = Console.ReadLine().Replace(" ", "").ToLower();

            Console.Write("Enter second String: ");
            String s2 = Console.ReadLine().Replace(" ", "").ToLower();

            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string sortde1 = new string(ch1);
            string sortde2 = new string(ch2);

            if (sortde1 == sortde2)
            {
                Console.WriteLine("String are Anagram");
            }
            else
            {
                Console.WriteLine("String are NOT Anagram");
            }
        }
    }
}