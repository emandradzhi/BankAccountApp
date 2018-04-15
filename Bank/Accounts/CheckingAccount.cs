using Bank.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Accounts
{
    class CheckingAccount : BaseAccount
    {
        public CheckingAccount(string fName, string lName, string ssn, string accType, double initialDeposit) 
            : base(fName, lName, ssn, accType, initialDeposit)
        {

        }
    }
}
