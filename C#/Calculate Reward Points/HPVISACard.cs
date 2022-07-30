using System;

class HPVISACard : VISACard
{
    public HPVISACard()
    {

    }
    public new double computeRewardPoints(string _type, double _amount)
    {
        double reward = base.computeRewardPoints(_type, _amount);
        if(string.Equals(_type, "Fuel"))
            return reward + 10;
        return reward;
    }
}