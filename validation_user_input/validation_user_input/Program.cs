using System;
class program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("enter your exam percentage");
            int per = Convert.ToInt32(Console.ReadLine());

            if (per < 0 || per > 100)
            {
                throw new ArgumentException("percentage must me between 0 to 100");
            }
            Console.WriteLine("result saved succesfully" + per + "%");
        }
        catch (FormatException)
        {
            Console.WriteLine("error:invalid number format");
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine("error:"+ex.Message);
        }
        finally
        {
            Console.WriteLine("input validation check complete");
        }
    }
}