using System;
public class Program{
    public static void Main(){
        Console.WriteLine("Enter Name");
        string n=Console.ReadLine();

        Console.WriteLine("Enter UserName");
         string u=Console.ReadLine();
        Console.WriteLine("Enter Password");
         string p=Console.ReadLine();
        Console.WriteLine("Enter PhoneNo");
         long pn=Convert.ToInt64(Console.ReadLine());
		//Fill your code here
        User user1=new User(n,u,p,pn);
        Console.WriteLine("Enter Name");
        n=Console.ReadLine();

        Console.WriteLine("Enter UserName");
         u=Console.ReadLine();
        Console.WriteLine("Enter Password");
         p=Console.ReadLine();
        Console.WriteLine("Enter PhoneNo");
          pn=Convert.ToInt64(Console.ReadLine());
		//Fill your code here
        User user=new User(n,u,p,pn);
        bool m=user.ComparePhoneNumber(user1);
        if(m==true)
            Console.WriteLine("Same Users");
        else
            Console.WriteLine("Different Users");
    }
}