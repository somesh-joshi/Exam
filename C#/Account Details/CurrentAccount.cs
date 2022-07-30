using System;
class CurrentAccount : Account
{
    private string _organizationName;
    private long _TIN;

    public CurrentAccount(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber,string _organizationName, long _TIN)
        : base(_holderName, _accountNumber, _IFSCCode, _contactNumber)
    {
        this._organizationName = _organizationName;
        this._TIN = _TIN;
    }
    
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Organization Name : " + _organizationName);
        Console.WriteLine("TIN : " + _TIN);
        
    }
}