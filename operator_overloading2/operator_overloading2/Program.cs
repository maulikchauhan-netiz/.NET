using System;
using System.Text.RegularExpressions;
namespace operator_overload
{
    class class1
    {
        public int number1, number2;

        public class1(int num1,int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static class1 operator -(class1 c1)
        {
            c1.number1 = -c1.number1;
            c1.number2 = -c1.number2;
            return c1;
        }
        public void print()
        {
            Console.WriteLine("number1 = " + number1);
            Console.WriteLine("number2 =" + number2);
        }
        static void Main(string[] args)
        {
            class1 calc = new class1(10,-25);
            Console.WriteLine("\n--------------------before operator overloading------------------------ ");
            calc.print();
            calc = -calc;
            Console.WriteLine("\n--------------------after operator overloading------------------------ ");
            calc.print();
            Console.ReadKey();
        }

    }
}