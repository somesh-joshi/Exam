using System;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Event Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Detail");
            string detail = Console.ReadLine();
            Console.WriteLine("Enter Organizer");
            string organizer = Console.ReadLine();
            Console.WriteLine("Select Event Type 1.Exhibition 2.StageEvent");
            int ch = Convert.ToInt32(Console.ReadLine());
          if(ch==1){
            Console.WriteLine("Enter stall count");
            int n=Convert.ToInt32(Console.ReadLine());
            var o1=new Exhibition(name,detail,organizer,n);
            o1.ToString();
            o1.TotalCredit();
          }
          else if(ch==2){
            Console.WriteLine("Enter Total shows");
            int sh=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter seats per show");
            int se=Convert.ToInt32(Console.ReadLine());
            var o2=new StageEvent(name,detail,organizer,sh,se);
            o2.ToString();
            o2.TotalCredit();

          }
          else{
            Console.WriteLine("Enter valid choice");
          }

        }
    }