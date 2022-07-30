using System;
using System.Globalization;
public class Program

{
    public static void Main(string[] args)
    {
        
		
			Console.WriteLine("Enter the Event Name:");
            string Name=Console.ReadLine();
            Console.WriteLine("Enter the Event Date:");
            DateTime Date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the Event Organizer:");
            string Organizer=Console.ReadLine();
            Console.WriteLine("Enter the Event Type(Exhibition/Stage Event):");
            string Type=Console.ReadLine();
            if (String.Equals(Type, "Stage Event"))
            {
                Console.WriteLine("Enter the Show Type:");
                string Show = Console.ReadLine();
                StageEvent sr = new StageEvent(Name, Date, Type, Organizer, Show);
                sr.Display();

            }
            else if (String.Equals(Type, "Exhibition"))
            {
                Console.WriteLine("Enter the Stall Type:");
                string Esc = Console.ReadLine();
                Exhibition exhibition = new Exhibition(Name, Date, Type, Organizer, Esc);
                exhibition.Display();
            }
            else
            {
                Console.WriteLine("Enter the correct Event Type and try again...");
            }
    }
}