using Bank.Accounts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseAccount> accounts = File.ReadAllLines("Accounts.csv")
                .Select(a => FromCsv(a))
                .ToList();



            
            Console.ReadKey(true);
        }

        //TODO: This is a stupid way of seeding data, refactor this later

        static BaseAccount FromCsv(string line)
        {
            string[] element = line.Split(',');
            BaseAccount accountValues = new BaseAccount(
                element[0],
                element[1],
                element[2],
                element[3],
                double.Parse(element[4]));


            return accountValues;
        }

    }
    
}
