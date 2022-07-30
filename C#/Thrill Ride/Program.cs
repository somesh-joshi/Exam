using System;

class Program {
    static void Allw(int s) {
        if (s < 15 || s > 60) {
            Console.WriteLine("Not Allowed");
        } else {
            Console.WriteLine("Allowed");
        }
    }
    public static void Main(String[] args) {
        int branding = Convert.ToInt32(Console.ReadLine());
        Allw(branding);
    }
}