using System;
using System.Collections.Generic;

public class Citizen
{
    string _name;
    int _age;
    public string Name
    {
        get
        {
            return this._name;
        }
        set
        {
            this._name = value;
        }
    }

    public int Age
    {
        get
        {
            return this._age;
        }
        set
        {
            this._age = value;
        }
    }


    public static void DisplayPeople(Citizen people, FilterPerson childFilter, FilterPerson adultFilter, FilterPerson seniorFilter)
    {
        //Fill code here
        if(childFilter(people))
            Console.WriteLine(people.Name+" is Child");
        if(adultFilter(people))
            Console.WriteLine(people.Name+" is Adult");
        if(seniorFilter(people))
            Console.WriteLine(people.Name+" is Senior");
    }

    public static bool IsChild(Citizen p)
    {
        //Fill code here
        if(p.Age<=18)
            return true;
        else
            return false;
    }

    public static bool IsAdult(Citizen p)
    {
        if(p.Age>18 && p.Age<60)
            return true;
        else
            return false;
       //Fill code here
    }

    public static bool IsSenior(Citizen p)
    {
        //Fill code here
        if(p.Age>=60)
            return true;
        else
            return false;
    }
}