using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the stall type");
        string s=Console.ReadLine();
        Console.WriteLine("Enter the square feet");
        int sq=Convert.ToInt32(Console.ReadLine());
        if(s=="Gold"){
            var o=new Stall();
            o.ComputeCost(s,sq);
        }
        else if(s=="Diamond"){
            var o=new Stall();
            Console.WriteLine("Enter the number of TV");
            int tv=Convert.ToInt32(Console.ReadLine());
            o.ComputeCost(s,sq,tv);
        }
        else{
            string m;
            Console.WriteLine("Do you need a projector(yes/no)");
            m=Console.ReadLine();
            bool b=false;
            if(m=="yes")
                b=true;
            var o=new Stall();
            o.ComputeCost(s,sq,b);
            
        }

        //fill code here
    }
}