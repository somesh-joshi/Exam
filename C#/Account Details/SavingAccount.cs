using System;
class SavingAccount : Account
{
    private double _interestRate;


    public SavingAccount(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber, double _interestRate)
        : base ( _holderName, _accountNumber, _IFSCCode, _contactNumber)
    {
        this._interestRate = _interestRate;
    }
    
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Interest Rate : " + _interestRate);
        //Fill your code here
    }
    
}