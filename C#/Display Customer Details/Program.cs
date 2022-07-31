using System;

class Program
{
    //fill code here
    public delegate void NameDelegate() ;
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the first name:");
        string fn=Console.ReadLine();
        Console.WriteLine("Enter the last name:");
          string ln=Console.ReadLine();
        var o=new Customer(fn,ln);


        Console.WriteLine("Customer Details");
        NameDelegate nd=new NameDelegate(o.DisplayFirstName);
        nd+=new NameDelegate(o.DisplayLastName);
        nd();

        //fill code here
    }
}