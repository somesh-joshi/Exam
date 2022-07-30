using System;
class Exhibition : Event
    {
        private static int _gst = 5;
        private int _noOfStalls;
        public Exhibition() { }
        public Exhibition(string _name, string _type, double _costPerDay, int _noOfDays, int _noOfStalls)
            :base(_name,_type,_costPerDay,_noOfDays)
        {
            this._noOfStalls = _noOfStalls;


        }
        public double totalCost()
        {
            double totalCost = _costPerDay * _noOfDays;
            totalCost = totalCost + _gst * totalCost / 100;
            return totalCost;
        }
        public override string ToString()
        {
            //Fill your code here
            base.ToString();
            Console.WriteLine("Number of stalls:" + _noOfStalls);
            string s = totalCost().ToString("0.00");
            Console.WriteLine("Total amount:"+s);
            return "";

        }
    }