using System;
public class TicketBooking
{
    public void MakePayment(double amount)
    {
        Console.WriteLine("You have selected the Cash payment mode");
        Console.WriteLine("The Amount is Rs.{0}.",amount);
        //fill your code here
    }

    public void MakePayment(string walletNumber, double amount)
    {
        Console.WriteLine("You have selected the Wallet payment mode");
        //fill your code here
         Console.WriteLine("Wallet Number: {0}\nThe Amount is Rs.{1}.",walletNumber,amount);

    }

   public void MakePayment(string creditCard, string ccv, string name, double amount)
    {

        Console.WriteLine("You have selected the Credit Card payment mode");
        //fill your code here;
        Console.WriteLine("CreditCard Number: {0}\nValidity Date: {1}\nCard Holder Name: {2}\nThe Amount is Rs.{3}.",creditCard,ccv,name,amount);

    }
}