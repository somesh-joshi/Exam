using System;
    class Exhibition : Event
    {
        //Fill your code here
        private int _stallCount;
        public Exhibition(string _name, string _detail, string _organizer, int _stallCount):base(_name, _detail,_organizer)
        {
             this._stallCount=_stallCount;
        }
        public override void TotalCredit()
        {
             base.TotalCredit();
             //Fill your code here
             double d=_stallCount*50;
             string s=d.ToString("0");
             Console.WriteLine("Total Credit Gained is {0}",s);
        }
        public override string ToString()
        {
             //Fill your code here
             Console.WriteLine("Event Name : {0}\nEvent Detail : {1}\nEvent Organizer : {2}",_name,_detail,_organizer);
             Console.WriteLine("Stall Count : {0}",_stallCount);
             return "";
        }

    }