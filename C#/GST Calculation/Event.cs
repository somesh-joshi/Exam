using System;
class Event
{
    protected string _name;
    protected string _type;
    protected double _costPerDay;
    protected int _noOfDays;
    
     public Event() { }
        public Event(string _name, string _type, double _costPerDay, int _noOfDays)
        {
            this._name = _name;
            this._type = _type;
            this._costPerDay = _costPerDay;
            this._noOfDays = _noOfDays;
        }

         public override string ToString()
        {
            //Fill your code here
            Console.WriteLine("Name:" +_name);
            Console.WriteLine("Type:" + _type);
            return "";
        }
    //Fill your code here
}