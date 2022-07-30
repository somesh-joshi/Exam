using System;
using System.Globalization;

class Program {

    public static void Main(String[] args) {
        Console.WriteLine("Enter branding expenses");
        int branding = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter travel expenses");
        int travel = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter food expenses");
        int food = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter logistics expenses");
        int logistics = Convert.ToInt32(Console.ReadLine());
        double total = branding + travel + food + logistics;
        double perBranding = (branding / total) * 100;
        double perTravel = (travel / total) * 100;
        double perFood = (food / total) * 100;
        double perLogistics = (logistics / total) * 100;
        string sttotal = String.Format("{0:0.00}", total);
        string stperBranding = String.Format("{0:0.00}", perBranding);
        string stperTravel = String.Format("{0:0.00}", perTravel);
        string stperFood = String.Format("{0:0.00}", perFood);
        string stperLogistics = String.Format("{0:0.00}", perLogistics);
        Console.WriteLine("Total expenses:Rs.{0}", sttotal);
        Console.WriteLine("Branding expenses percentage:{0}%", stperBranding);
        Console.WriteLine("Travel expenses percentage:{0}%", stperTravel);
        Console.WriteLine("Food expenses percentage:{0}%", stperFood);
        Console.WriteLine("Logistics expenses percentage:{0}%", stperLogistics);
    }
}