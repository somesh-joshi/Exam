using System;
class Program
{
    static void Main(string[] args)
    {
        string check = "Yes";
        while(check == "Yes")
        {
            Console.WriteLine("Enter the transaction detail");
            string input = Console.ReadLine();
            string[] words = input.Split(',');
            string Type = words[0];
            double Amount = Convert.ToDouble(words[1]);
            string Card = words[2];
            
            if(string.Equals(Card, "VISA card"))
            {    
                VISACard vc = new VISACard();
                double reward = vc.computeRewardPoints(Type, Amount);
                string rew = reward.ToString("0.00");
                Console.WriteLine("Total reward points earned in this transaction is " + rew);
            }
            else if(string.Equals(Card, "HPVISA card"))
            {
                HPVISACard vc = new HPVISACard();
                double reward = vc.computeRewardPoints(Type, Amount);
                string rew = reward.ToString("0.00");
                Console.WriteLine("Total reward points earned in this transaction is " + rew);                
            }
            else
                Console.WriteLine("Invalid data");
            
            Console.WriteLine("Do you want to continue?(Yes/No)");
            check = Console.ReadLine();
            
        }
    }
}