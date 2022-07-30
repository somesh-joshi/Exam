using System;

class Stall
{
    public void ComputeCost(string _stallType, int _squareFeet)
    {
        //fill code here
        Console.WriteLine("Gold costs Rs.{0}",(_squareFeet*100));
    }

    public void ComputeCost(string _stallType, int _squareFeet, int _numberOfTV)
    {
        //fill code here
        Console.WriteLine("Diamond costs Rs.{0}",((_squareFeet*150)+(100*_numberOfTV)));
    }

    public void ComputeCost(string _stallType, int _squareFeet, bool _projectorAvailability)
    {
        int d=_squareFeet*200;
        if(_projectorAvailability==true){
            d=d+1000;
        }
        Console.WriteLine("Platinum costs Rs.{0}",d);
        //fill code here
    }
}