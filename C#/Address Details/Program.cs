using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {    
           string str;  
           Address a;         
           Dictionary<string, List<Address>> d=new Dictionary<string, List<Address>>();
           Console.WriteLine("Enter the number of details:");
          int n = Convert.ToInt32(Console.ReadLine());         
           Console.WriteLine("Enter the address details:");         
            for (int i = 0; i < n; i++){
              //fill your code here 
             str=Console.ReadLine();     
             string[] s=str.Split(',');            
             int x=Convert.ToInt32(s[4]);              
             a=new Address(s[0],s[1],s[2],s[3],x);              
             if(d.ContainsKey(s[2])){                 
                 List<Address> l=d[s[2]];                 
                 l.Add(a);                
                 d[s[2]]=l;              
             }else{                 
                  List<Address> l=new List<Address>();                
                  l.Add(a);                  
                  d.Add(s[2],l);              
                }          
            }       
           Console.WriteLine("Enter the city to view:"); 
             string city = Console.ReadLine();    
                   //fill your code here          
                   if(d.ContainsKey(city)){             
                        Console.WriteLine("Address Details:");          
 			Console.WriteLine("Address1                       Address2                       City            State           Pincode   ");              
                        List<Address> m=d[city];              
                        foreach(var t in m){                  
                            Console.WriteLine(t.ToString());             
                         }        
                      }         
                       else{                 
     Console.WriteLine("Address Details for the selected city not found...");          
                        }  
    }
}