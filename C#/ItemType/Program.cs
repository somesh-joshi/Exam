using System;
public class Program{
    public static void Main(){
        
        ItemType itemType = new ItemType();
        Console.WriteLine("Enter the item type name");
        itemType.Name = Console.ReadLine();
        Console.WriteLine("Enter the cost per day");
        itemType.CostPerDay = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the deposit");
        itemType.Deposit = Convert.ToDouble(Console.ReadLine());

        
        itemType.Display();
    }
}