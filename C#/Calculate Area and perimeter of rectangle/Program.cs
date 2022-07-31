using System;

class Program
{
    public delegate void rectangleDelegate(double width, double height);
    //fill code here

    public void PrintArea(double height, double width)
    {
        //fill code here
        Console.WriteLine("Area is: "+(height*width));
    }

    public void PrintPerimeter(double height, double width)
    {
        //fill code here
        Console.WriteLine("Perimeter is: "+(2*(height+width)));
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine("Enter the width");
        double wi=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height");
        double hi=Convert.ToDouble(Console.ReadLine());
        rectangleDelegate rd=new rectangleDelegate(p.PrintArea);
        rd+=new rectangleDelegate(p.PrintPerimeter);
        rd(wi,hi);
        //fill code here
    }
}