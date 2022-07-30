using System;
using System.Collections.Generic;
class Program
    {
        static void Main(string[] args)
        {
                    //Fill Your Code Here 
                 HashSet < string > h = new HashSet < string >();    
                 Console.WriteLine("Enter the size of the userlist"); 
                 int n=Convert.ToInt32(Console.ReadLine()); 
                 for(int i=0;i<n;i++){       
                   string str=Console.ReadLine();
                          if(str!=""){h.Add(str);}
                 }             
             Console.WriteLine("Total number of unique users "+h.Count);  
        }
}