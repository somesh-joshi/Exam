using System;
using System.Reflection;


internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attributes present in Hall class");
            foreach (var prop in typeof(Hall).GetProperties())
            {
                string s = Convert.ToString(prop.PropertyType);
                Console.WriteLine(s.Substring(s.IndexOf(".")+1) +" "+ prop.Name);
            }
        }
    }