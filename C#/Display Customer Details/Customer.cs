using System;
using System.Collections.Generic;
using System.Text;

class Customer
{
    public string _firstName;
    public string _lastName;

    public Customer(string _firstName, string _lastName)
    {
        this._firstName = _firstName;
        this._lastName = _lastName;
    }

    public void DisplayFirstName()
    {
        //fill code here
        Console.WriteLine("First Name: "+this._firstName);
    }

    public void DisplayLastName()
    {
        //fill code here
           Console.WriteLine("Last Name: "+this._lastName);
    }
}