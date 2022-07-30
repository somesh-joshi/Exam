using System;

public class Program {
	public static void Main(string[] args)
	{
        
        
        Console.WriteLine("Enter the Customer Details\nEnter the name");
        string n=Console.ReadLine();
         Console.WriteLine("Enter the email");
         string e=Console.ReadLine();
          Console.WriteLine("Enter the type");
          string t=Console.ReadLine();
           Console.WriteLine("Enter the location");
           string a=Console.ReadLine();
            
        Customer c=new Customer(n,e,t,a);
        Console.WriteLine();
        c.DisplayDetails();
		//Fill your code
	}
}