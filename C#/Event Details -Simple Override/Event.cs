using System;
class Event
    {
        protected string _name;
        protected string _detail;
        protected string _organizer;
        //Fill your code here
         public  Event(string _name, string _detail, string _organizer){
             this._name=_name;
             this._detail=_detail;
             this._organizer=_organizer;
         }
         public virtual void TotalCredit(){
             Console.WriteLine("Credit Details");
         }
         
    }