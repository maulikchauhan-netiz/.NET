using System;
namespace abstract_class2
{
    public abstract class shape
    {
        public abstract void area();
    }
    public class circle : shape
    {
        int r;
        public override void area()
        {
            Console.Write("enter the radius of circle : ");
            r = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("area of the circle is : " + (3.14 * r * r));
        }
    }
    public class square : shape
    {
        int s;
        public override void area()
        {
            Console.Write("enter the value");
            s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("area of circle is : " + (s * s));
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            shape sh;
            sh = new circle();
            sh.area();
            sh = new square();
            sh.area();
        }
    }
}
