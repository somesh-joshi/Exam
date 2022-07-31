using System;

//fill code here
class Program
{
    public delegate void CalculateDelegate(int num1, int num2);
    public static void Addition(int num1, int num2) {
        //fill code here
        Console.WriteLine("The sum is : "+(num1+num2));
    }

    public static void Subtract(int num1, int num2)
    {
	    //fill code here
         Console.WriteLine("The subtraction is : "+(num1-num2));
    }

    static void Main(string[] args)
    {
	    //fill code here
        Console.WriteLine("Enter the num1");
        int n1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the num2");
        int n2=Convert.ToInt32(Console.ReadLine());
        CalculateDelegate ca=Program.Addition;
        ca+=Program.Subtract;
        ca(n1,n2);
    }
}
