using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the class name:");
        string s = Console.ReadLine();
        Assembly exec = typeof(Program).Assembly;
        Type[] types = exec.GetTypes();
        foreach(var i in types){
            if(i.FullName == s){
                Console.WriteLine("Class Full Name: "+ i.FullName);
                Console.WriteLine("Base Type: "+i.BaseType);
                Console.WriteLine("Is Class: "+i.IsClass);
                Console.WriteLine("Is Interface: "+i.IsInterface);
            }
        }
    }
}