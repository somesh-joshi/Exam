using System;
class Program {
	public static void Main(string[] args) {
		Console.WriteLine("Enter the length of the rectangle");
		int l=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the width of the rectangle");
		int w=Convert.ToInt32(Console.ReadLine());
		Rectangle rec=new Rectangle(l,w);
		rec.Display();
	
		//Fill your code here
		Console.WriteLine("Enter the new dimension");
		int d=Convert.ToInt32(Console.ReadLine());
		var o=rec.DimensionChange(d);
		o.Display();
		

	}
}