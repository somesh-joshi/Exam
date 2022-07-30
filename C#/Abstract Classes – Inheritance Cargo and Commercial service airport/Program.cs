using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        //Fill your code here
        string p="";
        Console.WriteLine("Enter the name");
        string n=Console.ReadLine();
        Console.WriteLine("Enter the city");
        string c=Console.ReadLine();
        Console.WriteLine("Enter the number of flights per day");
        int no=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the number of passengers travelling in each flight");
        int nop=Convert.ToInt32(Console.ReadLine());
        var obj=new CommercialServiceAirport(p,n,c,no,nop);
         Console.WriteLine("Enter the number of cargo units shipped in each flight");
        int noc=Convert.ToInt32(Console.ReadLine());
        var ob=new CargoServiceAirport(p,n,c,no,noc);
        Console.WriteLine("Airport Details\nNumber of passengers travelled/day:{0}\nNumber of cargo units shipped/day:{1}",obj.calculate(),ob.calculate());   
         }
}