using System;
class Program {
    public static void Main(String[] args) {
        //Fill your code here
        int n = Convert.ToInt32(Console.ReadLine());
        if(n<15)
            Console.WriteLine("Child Ticket");
        else
            Console.WriteLine("Adult Ticket");
    }
}