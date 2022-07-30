using System;
public class StageEvent : Event
{
    private string _showType;
    public StageEvent() { }
        public StageEvent(string _name, DateTime _date, string _type, string _organizer, string _showType)
            :base (_name,_date,_type,_organizer)
        {
            this._showType= _showType;
        }

        public void Display()
        {
            Console.WriteLine("Event Name: " + _name);
            Console.WriteLine("Event Date: " + _date.ToString("dd/MM/yyyy"));
            Console.WriteLine("Event Organizer: " + _organizer);
            Console.WriteLine("Event Type: " + _type);
            Console.WriteLine("Show Type: " +_showType);

        }
    //Fill your code
}