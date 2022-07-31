using System;
using System.Collections.Generic;

//Declare delegate
namespace Myclass{
    
    public delegate bool FilterEligiblePeople(Citizen p, int minAge, int maxAge); 
public class Program
{
    static void Main(string[] args)
    {
        Citizen p = new Citizen();
        Console.WriteLine("Enter the citizen details");
        Console.WriteLine("Enter the name");
        string n=Console.ReadLine();
        p.Name=n;

        Console.WriteLine("Enter the age");
        int a=Convert.ToInt32(Console.ReadLine());
        p.Age=a;

        Console.WriteLine("Enter the min age");
        int minAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the max age");
        int maxAge = Convert.ToInt32(Console.ReadLine());
        //Fill your code
        FilterEligiblePeople ft=new FilterEligiblePeople(Citizen.IsEligible);
        Citizen.CheckPeopleEligible(p,minAge,maxAge,ft);
    }
}
}