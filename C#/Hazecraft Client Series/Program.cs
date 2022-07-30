using System;
class Program {
    public static void Main(String[] args) {
        //Fill your code here
        var n = Convert.ToInt32(Console.ReadLine());

        for(int i = 2, k = 1;k<=n;i++)
        {
            if(Prime(i))
            {   
                Console.Write(i + " ");
                k++;
            }
        }
    }
    public static bool Prime(int n)
    {
        for(int i=2;i<n;i++)
            if(n%i == 0)
                return false;
        return true;
    }
}