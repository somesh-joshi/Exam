using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SeniorCitizenCustomer //Fill your code here
{
    public double GenerateBillAmount(int amount)
    {
        return amount - amount*0.12;
    }
}