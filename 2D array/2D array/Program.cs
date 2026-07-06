using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr =
            {
                {50,20,60 },
                {50,20,80 },
                {80,50,70 }

            };
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Student:-", (i + 1) + "Marks:-");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i , j]);
                }
                Console.WriteLine();
            }

        }
    }
}


