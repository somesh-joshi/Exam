using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PlatinumStall :GoldStall
    {
        //Fill Your Code Here
        string _coupen;
        public PlatinumStall(string _name, string _detail, string _owner, double _costPerDay, double _discount, string _coupen):base(_name,_detail,_owner,_costPerDay,_discount){
            this._coupen=_coupen;
        }
        public override double  calculateRent(int days){
            double rent;
            if(_coupen=="yes")
                rent=((days * _costPerDay) - ((days * _costPerDay) * _discount/100))/2;
            else
                rent=(days * _costPerDay) - ((days * _costPerDay) * _discount/100);
            return rent;
        }
        public override string ToString()
        {
            Console.WriteLine("Name : {0}\nDetail : {1}\nOwner : {2}\nCost Per Day : {3}",_name,_detail,_owner,_costPerDay);
           //Fill Your Code Here
           return "";
        }
    
    }
