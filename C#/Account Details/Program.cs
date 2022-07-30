using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter User Details(HolderName,Account Number,IFSC code,Contact Number)");
        string details = Console.ReadLine();
        string[] words = details.Split(',');
        string HolderName = words[0];
        long AccountNumber = Convert.ToInt64(words[1]);
        string IFSC = words[2];
        long ContactNumber = Convert.ToInt64(words[3]);
        
        Console.WriteLine("Enter Account Type");
        string AccountType = Console.ReadLine();

        if(string.Equals(AccountType, "saving") == true)
        {
            Console.WriteLine("Enter Interest Rate");
            double Interest = Convert.ToDouble(Console.ReadLine());

            SavingAccount sa = new SavingAccount(HolderName, AccountNumber, IFSC, ContactNumber, Interest);
            sa.Display();
        }
        else if(string.Equals(AccountType, "current") == true)
        {
            Console.WriteLine("Enter organization Name");
            string Organization = Console.ReadLine();
            Console.WriteLine("Enter TIN number");
            long TIN = Convert.ToInt64(Console.ReadLine());

            CurrentAccount ca = new CurrentAccount(HolderName, AccountNumber, IFSC, ContactNumber, Organization, TIN);
            ca.Display();
        }
        else
            Console.WriteLine("Enter valid Account Type");

    }
}