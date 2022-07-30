using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter stall name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter stall detail");
            string detail = Console.ReadLine();
            Console.WriteLine("Enter stall owner name");
            string owner = Console.ReadLine();
            Console.WriteLine("Enter cost per day");
            double costPerDay = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("1.Stall 2.GoldStall 3.PlatinumStall");
            int ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Total Number of Days");
                int d=Convert.ToInt32(Console.ReadLine());
            if(ch==1){
                var o=new Stall(name,detail,owner,costPerDay);
                o.ToString();
                double re=o.calculateRent(d);
                string s=re.ToString("0");
                Console.WriteLine("Your Total Cost {0}",s);
            }
            else if(ch==2){
                Console.WriteLine("Enter discount percentage");
                double dis=Convert.ToDouble(Console.ReadLine());
                var o=new GoldStall(name,detail,owner,costPerDay,dis);
                o.ToString();
                double re=o.calculateRent(d);
                string s=re.ToString("0");
                Console.WriteLine("Your Total Cost {0}",s);
            }
            else if(ch==3){
                Console.WriteLine("Enter discount percentage");
                double dis=Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine("Coupon Yes/No");
                 string co=Console.ReadLine();
                var o=new PlatinumStall(name,detail,owner,costPerDay,dis,co);
                o.ToString();
                double re=o.calculateRent(d);
                string s=re.ToString("0");
                Console.WriteLine("Your Total Cost {0}",s);
            }

            //Fill Your Code Here
        }
    }