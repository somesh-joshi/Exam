using System;
class Account
{
    protected string _holderName;
    protected long _accountNumber;
    protected string _IFSCCode;
    protected long _contactNumber;

    public Account(string _holderName,long _accountNumber,string _IFSCCode,long _contactNumber)
    {
        this._holderName = _holderName;
        this._accountNumber = _accountNumber;
        this._IFSCCode = _IFSCCode;
        this._contactNumber = _contactNumber;
    }
    public virtual void Display()
    {
        Console.WriteLine("Your Contact Details");
        Console.WriteLine("HolderName : " + _holderName);
        Console.WriteLine("Account Number : " + _accountNumber);
        Console.WriteLine("IFSCCode : " + _IFSCCode);
        Console.WriteLine("ContactNumber : " + _contactNumber);
        
    }
}