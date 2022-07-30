using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Stall
{
	public string _name;
	public string _detail;
	public double _costPerDay;
	public string _owner;
	public Stall(string _name, string _detail, string _owner, double cost)
	{
		this._name = _name;
		this._detail = _detail;
		this._owner = _owner;
		this._costPerDay = cost;
	}
	public virtual double calculateRent(int days)
	{
		//Fill Your Code Here
      double  r= days*_costPerDay;
      return r;
	}
	
	public override string ToString()
	{
        Console.WriteLine("Name : {0}\nDetail : {1}\nOwner : {2}\nCost Per Day : {3}",_name,_detail,_owner,_costPerDay);
	   //Fill Your Code Here
       return "";
	}
}