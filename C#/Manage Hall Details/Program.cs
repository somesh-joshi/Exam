using System;
using System.Collections.Generic;  
using System.Linq;  
class Program  {      
static void Main(string[] args)      {         
    Hall h4;          
   string name,oname;          
   long ph;          
         double cost;          
         List<Hall> h=new List<Hall>();          
   Hall h1=new Hall("Hardy Marriage Hall",9092314678,200.0,"Hardy");            
   Hall h2=new Hall("ABC Party Hall",9092310078,120.0,"Ram");
         Hall h3=new Hall("Conferance Hall",9092314677,400.0,"Ravi");          
   h.Add(h1);
         h.Add(h2);          
   h.Add(h3);          
  while(true){
              Console.WriteLine("1.Add New Hall\n2.Display Hall\n3.Replace Hall\n4.Exit");
              Console.WriteLine("Enter your choice");
              int ch = Convert.ToInt32(Console.ReadLine());
              if(ch==1){
                  Console.WriteLine("Enter Name");
                  name=Console.ReadLine(); 
                  Console.WriteLine("Enter phoneNo");
                  ph=Convert.ToInt64(Console.ReadLine()); 
                  Console.WriteLine("Enter Cost Per Day"); 
                  cost=Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Enter Owner Name");
                  oname=Console.ReadLine();
                  h4=new Hall(name,ph,cost,oname);
                  h.Add(h4);
              }              
    else if(ch==2){
                  foreach(Hall o in h){ 
                     Console.WriteLine(o.ToString()); 
                  } 
                }
              else if(ch==3){
                Console.WriteLine("Enter the Index position");  
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");  
                name=Console.ReadLine();
                Console.WriteLine("Enter phoneNo");
                ph=Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Cost Per Day");
                cost=Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("Enter Owner Name");
                oname=Console.ReadLine();
                h4=new Hall(name,ph,cost,oname);
                h.Insert(n,h4);
              }              
              else if(ch==4){
                  break; 
              }
              else{  
                Console.WriteLine("Enter Valid Choice");  
              }          
  }
      }
  }