using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
public class BestMobilePlan
    {
        public static void printPlanDetails(int day,int night,int weekend)
        {
            int total1 = night*15 + weekend*20;
            if(day>100)
                total1 = (day-100)*25 + total1;

            int total2 = night*35 + weekend*25;
            if(day>250)
                total2 = (day-250)*45 + total2;
            
            string t1 = total1.ToString();
            string t2 = total2.ToString();
            t1 = t1.Substring(0,t1.Length-2) + "." + t1.Substring(t1.Length-2);
            t2 = t2.Substring(0,t2.Length-2) + "." + t2.Substring(t2.Length-2);
            Console.WriteLine("Plan A costs {0}\nPlan B costs {1}", t1, t2);
            if(total1<total2)
                Console.WriteLine("Plan A is cheapest");
            else if(total1>total2)
                Console.WriteLine("Plan B is cheapest");
            else
                Console.WriteLine("Plan A and B are the same price");
        }
    }