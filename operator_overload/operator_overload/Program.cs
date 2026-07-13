using System;
namespace operator_overload
{
    class class1
    {
        public int rno;
        public string name;
        public class1(int n,string nm)
        {
            rno = n;
            name = nm;
        }
        public static class1 operator + (class1 c1)
        {
            c1.rno = c1.rno + 100;
            c1.name = "hello" + c1.name;
            return c1;
        }
        public void print()
        {
            Console.WriteLine("roll no = " + rno);
            Console.WriteLine("name =" + name);
        }
        static void Main(string[] args)
        {
            class1 calc = new class1 ( 10 , "hello" );
            Console.WriteLine("\n--------------------before operator overloading------------------------ ");
            calc.print();
            calc = +calc;
            Console.WriteLine("\n--------------------after operator overloading------------------------ ");
            calc.print();
            Console.ReadKey();
        }
             
    }
}