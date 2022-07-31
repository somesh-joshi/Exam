using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the class name");
        string a = Console.ReadLine();
        Console.WriteLine("Methods present in {0} class",a);
        Assembly e = Assembly.GetExecutingAssembly();
        Type[] types = e.GetTypes();
        foreach(var i in types){
            if(i.FullName == a){
                MethodInfo[] m = i.GetMethods();
                foreach(var j in m){
                    string s = Convert.ToString(j.ReturnType);
                    Console.WriteLine(s.Substring(s.IndexOf(".")+1) +" "+ j.Name);
                }
            }
        }
    }
}