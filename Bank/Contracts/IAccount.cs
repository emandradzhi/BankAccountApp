using Bank.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Contracts
{
    public interface IAccount
    {
        void Deposit(double sum);
        
        void Withdraw(double sum);

        void Transfer(BaseAccount acc,double sum);
        
        void ShowInfo();

    }
}
