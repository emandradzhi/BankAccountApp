using Bank.Accounts;
using Bank.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Utils
{
    public class AccNumberGenerator
    {
        public static string GenerateChekingAccNum(BaseAccount acc)
        {
            //TODO: Refactor this later
            Random rand = new Random();
            string accNum = "";

            if (acc.SSN != null && acc != null)
            {
                if (acc.AccType.ToLower() == "checking")
                {
                    accNum = "2" + acc.SSN.Substring(acc.SSN.Length - 2) + rand.Next(0, 5).ToString() + rand.Next(0, 3).ToString();
                }
                else
                {
                    accNum = "1" + acc.SSN.Substring(acc.SSN.Length - 2) + rand.Next(0, 5).ToString() + rand.Next(0, 3).ToString();
                }
            }
            return accNum;


        }
        public static double GetInterestRate(BaseAccount acc)
        {
            double interestRate = 5;
            if (acc != null && acc.AccType.ToLower() == "saving")
            {
                return interestRate - 0.25;
            }
            else if (acc.AccType.ToLower() == "checking")
            {
                return interestRate;
            }
            else 
            {
                throw new Exception("ERROR!");
            }
            
        }
    }
}
