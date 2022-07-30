using System;
 
public class Program
{
	static void Main(string[] args)
	{
		var num = Convert.ToInt32(Console.ReadLine());
		var den = Convert.ToInt32(Console.ReadLine());

		PrintValue(num, den);
	}

	private static void PrintValue(int num,int den)
	{
		if(den == 0)
			Console.Write("0");
		else
		{
			int x = num;
			int y = den;
			int mod = 1;
			while(mod != 0)
			{
				mod = x%y;
				x = y;
				y = mod;
			}
			num /= x;
			den /= x;
			
			int quo = num/den;
			int rem = num%den;

			if(rem==0)
				Console.Write(quo);
			else
			{
				if(quo != 0)
					Console.Write(quo);
				Console.Write(" {0}/{1}", rem, den);
			}
		}
		
	}

}