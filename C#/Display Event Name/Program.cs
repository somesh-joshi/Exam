using System;

//fill code here
namespace SampleApp {
    public delegate string myDelegate(string str);

class Program
{
    event myDelegate newEvent;

    public Program()
    {
         this.newEvent += new myDelegate(this.WelcomeMessage);
        
    }

    public string WelcomeMessage(string eventName)
    {
        return "Welcome to the event " + eventName;
    }
    static void Main(string[] args)
    {
         Program obj1 = new Program();
         Console.WriteLine("Enter the event name");
         string st=Console.ReadLine();
         string result = obj1.newEvent(st);
         Console.WriteLine(result);
         //fill code here
    }
}
}