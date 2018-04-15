using Bank.Contracts;
using System;

namespace Bank.Accounts
{
    public class SavingAccount : BaseAccount
    {
        public SavingAccount(string fName, string lName, string ssn, string accType, double initialDeposit) 
            : base(fName, lName, ssn, accType, initialDeposit)
        {

        }
    }
}
