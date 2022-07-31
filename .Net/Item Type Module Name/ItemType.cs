using System;
using System.Collections.Generic;
using System.Text;

class ItemType
{
    private string _name;
    private double _deposit;
    private double _costPerDay;

    public ItemType() { }
    public ItemType(string _name, double _deposit, double _costPerDay)
    {
        this._name = _name;
        this._deposit = _deposit;
        this._costPerDay = _costPerDay;
    }

    public string Name
    {
        get{
            return this._name;
        }
        set{
            this._name = value;
        }
    }
    public double Deposit
    {
        get{
            return this._deposit;
        }
        set{
            this._deposit = value;
        }
    }
    public double CostPerDay
    {
        get{
            return this._costPerDay;
        }
        set{
            this._costPerDay = value;
        }
    }
}
