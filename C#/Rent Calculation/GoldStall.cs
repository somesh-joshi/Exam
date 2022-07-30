
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class GoldStall :Stall
    {
       public double _discount;
       public GoldStall(string _name, string _detail, string _owner, double _costPerDay, double _discount):base(_name,_detail,_owner,_costPerDay)
        {
           this._discount=_discount;
        }
      public override double calculateRent(int days){
         double rent=(days * _costPerDay) - ((days * _costPerDay )* _discount/100);
         return rent;
      }
       //Fill Your Code Here
        public override string ToString()
        {
         Console.WriteLine("Name : {0}\nDetail : {1}\nOwner : {2}\nCost Per Day : {3}",_name,_detail,_owner,_costPerDay);
           //Fill Your Code Here
           return "";
        
        }
    }