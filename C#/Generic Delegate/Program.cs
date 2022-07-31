using System;

class Program
{
    //Fill code here
    public delegate T  add<T>(T param1, T param2);
    static void Main(string[] args)
    {
        Console.WriteLine("Menu\n1.Add Integer\n2.Concatenate String");
        int choice = Convert.ToInt32(Console.ReadLine());
        int a, b;
        switch (choice) {
            case 1:
                Console.WriteLine("Enter the input a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the input b:");
                b = Convert.ToInt32(Console.ReadLine());
                //Fill code here
                add<int> ad=Program.Add;
                Console.WriteLine(ad(a,b));
                break;
            case 2:
                Console.WriteLine("Enter the string s1:");
                string s1 = Console.ReadLine();
                Console.WriteLine("Enter the string s2:");
                string s2 = Console.ReadLine();
                //Fill code here
                add<string> st=Program.Concat;
                Console.WriteLine(st(s1,s2));
                break;
        }
        Console.ReadLine();

        
    }

    public static int Add(int a, int b)
    {
        //Fill code here
        return a+b;
    }

    public static string Concat(string s1, string s2)
    {
        //Fill code here
        return s1+s2;
    }
}
