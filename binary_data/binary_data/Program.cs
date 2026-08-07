using System;
using System.IO;
namespace binarywriterexample
{
    class program
    {
        static void Main(string[] args)
        {
            using (BinaryWriter w1 = new BinaryWriter(File.Open("D:\\.NET\\binaryfile.dat", FileMode.Create)))
            {
                w1.Write(12.5);
                w1.Write("this is string data");
                w1.Write(true);
            }
            using (BinaryReader reader = new BinaryReader(File.Open("D:\\.NET\\binaryfile.dat", FileMode.Open)))
            {
                Console.WriteLine("double value : " + reader.ReadDouble());
                Console.WriteLine("string value : " + reader.ReadString());
                Console.WriteLine("boolean value : " + reader.ReadBoolean());
            }
        }
    }
}