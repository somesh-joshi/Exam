using System;
class Program {
    public static void Main(String[] args) {
        //Fill your code here
        var n = Convert.ToInt32(Console.ReadLine());

        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=i;j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}