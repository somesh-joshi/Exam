using System;
using System.Reflection;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Virtual properties in type Song");
            foreach(var prop in typeof(Song).GetProperties()) {
                Console.WriteLine(prop.Name+" (type "+prop.PropertyType+")");
            }
        }
    }
