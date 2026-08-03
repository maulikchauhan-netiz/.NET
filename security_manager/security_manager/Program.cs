using System;

class employee
{
    private string name;

    public string n1
    {
        get
        {
            return name;

        }
        set
        {
            name = value;
        }
    }
}
class test
{
    static void Main (string[] args)
    {
        employee e1 = new employee();
        e1.n1 = "maulik";
        Console.WriteLine ("employee name is : "+e1.n1);
    }
}