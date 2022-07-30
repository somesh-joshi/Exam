using System;
class StageEvent:Event
    {
        static int _gst = 15;
        private int _noOfSeats;
        public StageEvent() { }
        public StageEvent(string _name, string _type, double _costPerDay, int _noOfDays, int _noOfSeats)
            :base(_name,_type,_costPerDay,_noOfDays)
        {
            this._noOfSeats = _noOfSeats;
        }


        public double totalCost()
        {
            //Fill your code here
            double totalCost = _costPerDay * _noOfDays;
            totalCost = totalCost + _gst * totalCost / 100;
            return totalCost;
            
        }
        public override string ToString()
        {
            //Fill your code here
            base.ToString();
            Console.WriteLine("Number of seats:" + _noOfSeats);
            string s = totalCost().ToString("0.00");
            Console.WriteLine("Total amount:" + s);
            return "";
        }


    }