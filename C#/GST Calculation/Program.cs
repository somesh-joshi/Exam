using System;
class Program
{
    static void Main(string[] args)
    {  Console.WriteLine("Enter event name");
        string _name = Console.ReadLine();
        Console.WriteLine("Enter the cost per day");
        double _costPerDay = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the number of days");
        int _noOfDays = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the type of event\n1.Exhibition\n2.Stage Event");
        int _type = Convert.ToInt32(Console.ReadLine());
        if( _type == 1 )
            {
                Console.WriteLine("Enter the number of stalls");
                int stall=Convert.ToInt32(Console.ReadLine());
                Exhibition ex = new Exhibition(_name,"Exhibition",_costPerDay,_noOfDays,stall);
                Console.WriteLine("Event Details");
                ex.ToString();
            }
            else if ( _type == 2 )
            {
                Console.WriteLine("Enter the number of seats");
                int sits=Convert.ToInt32(Console.ReadLine());
                StageEvent sc = new StageEvent(_name,"Stage Event",_costPerDay,_noOfDays,sits);
                Console.WriteLine("Event Details");
                sc.ToString();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        
        //Fill your code here
    }
}