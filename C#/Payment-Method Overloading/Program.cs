using System;
public class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the mode of Payment:\n1.Cash Payment\n2.Wallet Payment\n3.Credit Card");
        int n=Convert.ToInt32(Console.ReadLine());
        var obj=new TicketBooking();
        if(n==1){
            Console.WriteLine("Enter the Amount of Payment:");
            double am=Convert.ToDouble(Console.ReadLine());
            obj.MakePayment(am);
        }
        else if(n==2){
            Console.WriteLine("Enter the Wallet Number:");
            string vn=Console.ReadLine();
            Console.WriteLine("Enter the Amount of Payment:");
            double aam=Convert.ToDouble(Console.ReadLine());
            obj.MakePayment(vn,aam);
        }
        else if(n==3){
            Console.WriteLine("Enter the Credit Card Number:");
            string cn=Console.ReadLine();
            Console.WriteLine("Enter the Validity Date(dd/MM/yyyy):");
            string dd=Console.ReadLine();
            Console.WriteLine("Enter the Card Holder Name:");
            string hn=Console.ReadLine();
            Console.WriteLine("Enter the Amount of Payment:");
            double aaam=Convert.ToDouble(Console.ReadLine());
            obj.MakePayment(cn,dd,hn,aaam);
        }
        else
            Console.WriteLine("Please select the correct mode of payment...");
    }
}