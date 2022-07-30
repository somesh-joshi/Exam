using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
public class Program
    {
        static void Main(string[] args)
        {
            int day = Convert.ToInt32(Console.ReadLine());
            int night = Convert.ToInt32(Console.ReadLine());
            int weekend = Convert.ToInt32(Console.ReadLine());
            BestMobilePlan.printPlanDetails(day,night,weekend);
        }
    }