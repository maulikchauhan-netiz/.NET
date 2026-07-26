using System;
namespace program
{
    class employee
    {
        private string Name;
        public string name
        {
            get
            {
                return Name;
            }
            set
                {
                Name = value;
            }
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            employee e1 = new employee();
            e1.name = "Maulik";
            Console.WriteLine("Name is: " + e1.name);
            Console.ReadKey();
        }
    }
}