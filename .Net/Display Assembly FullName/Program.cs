using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Menu\n1.int\n2.double\n3.string\n4.Program");
        int choice = Convert.ToInt32(Console.ReadLine());
        if(choice == 1){
            Console.WriteLine(typeof(int).Assembly.FullName);
        }else if(choice == 2){
            Console.WriteLine(typeof(double).Assembly.FullName);
        }else if(choice == 3){
            Console.WriteLine(typeof(string).Assembly.FullName);
        }else if(choice == 4){
            Console.WriteLine(typeof(Program).Assembly.FullName);
        }else{
            Console.WriteLine("Invalid input");
        }
    }
}