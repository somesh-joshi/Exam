using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program{
    static void Main(string[] args){
        Console.WriteLine("1)Privilege Customer\n2)SeniorCitizen Customer\nEnter Customer Type");
        int ch = int.Parse(Console.ReadLine());
        if (ch > 0 && ch < 3)
        {
            Console.WriteLine("Enter The Name");
            var Name = Console.ReadLine();
            Console.WriteLine("Enter The Age");
            var Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Address");
            var Address = Console.ReadLine();
            Console.WriteLine("Enter The Mobile Number");
            var Mobile = Console.ReadLine();
            Console.WriteLine("Enter The Purchased Amount");
            var Bill = Convert.ToInt32(Console.ReadLine());
            var sBill = Bill.ToString("0.0");

            Customer customer = new Customer(Name, Address, Mobile, Age);
            if (ch == 1)
            {
                PrivilegeCustomer privilege = new PrivilegeCustomer();
                var Amount = privilege.GenerateBillAmount(Bill);
                var sAmount = Amount.ToString("0.00");
                Console.WriteLine("Bill Details\nName {0}\nMobile {1}\nAge {2}\nAddress {3}", Name, Mobile, Age, Address);
                Console.WriteLine("Your bill amount is Rs {0}. Your bill amount is discount under privilege customer\nYou have to pay Rs {1}", sBill,sAmount);
            }
            else
            {
                SeniorCitizenCustomer senior = new SeniorCitizenCustomer();
                var Amount = senior.GenerateBillAmount(Bill);
                var sAmount = Amount.ToString("0.00");
                Console.WriteLine("Bill Details\nName {0}\nMobile {1}\nAge {2}\nAddress {3}", Name, Mobile, Age, Address);
                Console.WriteLine("Your bill amount is Rs {0}. Your bill amount is discount under senior citizen customer\nYou have to pay Rs {1}", sBill,sAmount);
            }
        }
        else{
            Console.WriteLine("Invalid Customer Type");
        }
    }
}