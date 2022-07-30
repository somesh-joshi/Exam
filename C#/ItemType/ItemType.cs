using System;
public class ItemType{
    private string _name;   
    public string Name 
    {      
        get{return this._name;}
        set{this._name = value;} 
    }   
    private double _costPerDay; 
    public double CostPerDay 
    {
        get{return this._costPerDay;}
        set{this._costPerDay = value;} 
    }
    private double _deposit;   
    public double Deposit 
    {
        get{return this._deposit;}
        set{this._deposit = value;} 
    }

    public void Display() 
    {
        

        string c = _costPerDay.ToString("0.00");
        string d = _deposit.ToString("0.00");
        Console.WriteLine("Item type details");
        Console.WriteLine("Name:{0}\nCostPerDay:{1}\nDeposit:{2}",_name, c, d);
    }
}