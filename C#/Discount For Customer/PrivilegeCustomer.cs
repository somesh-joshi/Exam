using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PrivilegeCustomer 
{
    public double GenerateBillAmount(int amount)
    {
        return amount - amount*0.3;
    }
}