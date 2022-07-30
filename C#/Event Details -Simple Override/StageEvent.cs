using System;
class StageEvent : Event
    {
        private int	_totalShow;
        private int	_seatsPerShow;
       //Fill your code here
       public StageEvent(string _name, string _detail, string _organizer, int _totalShow, int _seats):base(_name,_detail,_organizer){
           this._totalShow=_totalShow;
           this._seatsPerShow=_seats;
       }
        public override void TotalCredit()
        {
            base.TotalCredit();
            double d=(_totalShow*_seatsPerShow)*100;
            string s=d.ToString("0");
            //Fill your code here'
           
            Console.WriteLine("Total Credit Gained is {0}",s);
        }
        public override string ToString()
        {
            Console.WriteLine("Event Name : {0}\nEvent Detail : {1}\nEvent Organizeer : {2}",_name,_detail,_organizer);
            Console.WriteLine("Total Events : {0}",_totalShow);
            Console.WriteLine("Total Seats : {0}",_seatsPerShow);
            
             
             return "";
           //Fill your code here 
        }
    }
