using System;
using System.Collections.Generic;

public delegate bool FilterPerson(Citizen p);

public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the citizen details");
        Citizen p = new Citizen();
        Console.WriteLine("Enter the name");
        string n=Console.ReadLine();

        Console.WriteLine("Enter the age");
        int a=Convert.ToInt32(Console.ReadLine());

        p.Name=n;
        p.Age=a;
        FilterPerson childFilter=new FilterPerson(Citizen.IsChild);
         FilterPerson adultFilter=new FilterPerson(Citizen.IsAdult);
        FilterPerson seniorFilter=new FilterPerson(Citizen.IsSenior);
        Citizen.DisplayPeople(p,childFilter,adultFilter,seniorFilter);
        


        //Fill your code here

    }
}