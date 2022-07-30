using System;
using System.Collections.Generic;  
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of seats per row");
        int seatsPerRow = Convert.ToInt32(Console.ReadLine());   
        List<List<Seat>> list = new List<List<Seat>>(); 
        char c = 'A';
        for(int i=0;i<rows;i++){     
             List<Seat> s = new List<Seat>();  
             for(int j=0;j<seatsPerRow;j++){    
              s.Add(new Seat(c,j+1,false));          
         
             }
                c++;       
               list.Add(s);    
       }       
    Console.WriteLine("Enter the seats to book");  
    string seats = Console.ReadLine(); 
    string[] seatsToBook = seats.Split(',');  
    foreach(string s in seatsToBook){ 
        int i = s[1]-'0';         
         try{                 
             if(list[Convert.ToInt32(s[0]-'A')][i-1].Booked == false){ 
                 list[Convert.ToInt32(s[0]-'A')][i-1].Section = '-';        
                 list[Convert.ToInt32(s[0]-'A')][i-1].Booked = true;  
             }             
            }              
            catch(Exception e){   
               Console.WriteLine("Invalid seat number {0}",s); 
            }    
    }      
    Console.WriteLine("Booked Seats");  
    foreach(var sublist in list){        
      foreach(var seat in sublist){   
        if(seat.Booked){    
         Console.Write(seat.Section+" ");    
        }     
         else{          
            Console.Write(seat.Section+""+seat.Number+" ");         
         }           
       }              
       Console.WriteLine();   
    }                  
    }
}