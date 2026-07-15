using System;

namespace abstract_class
{
    public abstract class vehicals
    {
        public abstract void startengine();
    }
    public class car : vehicals
    {
        public override void startengine()
        {
            Console.WriteLine("car engine started");
        }
    }
    public class motorcycle : vehicals
    {
        public override void startengine()
        {
            Console.WriteLine("motorcycle engine is started");
        }
    }
    public class test
    {
        public static void Main()
        {
            vehicals myvehicals;
            myvehicals = new car();
            myvehicals.startengine();

            myvehicals=new motorcycle();
            myvehicals.startengine();

        }
    }
}