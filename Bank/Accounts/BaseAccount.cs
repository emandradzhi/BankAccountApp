using Bank.Contracts;
using Bank.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Accounts
{
    public class BaseAccount : IAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string AccType { get; set; }
        public double InitialDeposit { get; set; }
        public string DAN { get; set; }
        public double InterestRate { get; set; }


        public BaseAccount(string fName, string lName, string ssn, string accType,double initialDeposit)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.SSN = ssn;
            this.AccType = accType;
            this.InitialDeposit = initialDeposit;
            this.DAN = AccNumberGenerator.GenerateChekingAccNum(this);
            this.InterestRate = AccNumberGenerator.GetInterestRate(this);
        }

        public void Deposit(double sum)
        {
            InitialDeposit += sum;
        }
        
        public void Transfer(BaseAccount accToTransfer, double sum)
        {
            accToTransfer.Deposit(sum);
        }

        public void Withdraw(double sum)
        {
            if (InitialDeposit - sum > 0)
            {
                InitialDeposit -= sum;
            }
            else return;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Hello {FirstName} {LastName}\r\n" +
                $"You have a {AccType} account \r\n" +
                $"Your balance is {InitialDeposit}");
        }

    }
}
