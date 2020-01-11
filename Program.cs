using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _78_Introduction_to_Inheritance
{   class Account // class named Account
    {
        private string id; // class data member string type named id
        private decimal balance; // class data member deciaml type named balance

        public Account() // default constructor named Account
        {
            id = " ";
            balance = 0;
        }
        public Account(string idNum, decimal bal) // fully parametized constructor w/2 constructors
        {
            id = idNum;
            balance = bal;
        }
        public void deposit(decimal amount)
        {
            balance += amount; // add amount and current balance and store in balance 
        }
        public void withdraw(decimal amount)
        {
            balance -= amount;
        }
        public override string ToString() // toString method 
        {
            return id + ": " + balance;
        }

    class CheckingAccount : Account // class inheritance from class Account to sub class CheckingAccount
        {
            public CheckingAccount(string idNum, decimal bal)
                : base(idNum, bal)
            {

            }
        }
           

    }
    class Program
    {
        static void Main(string[] args)
        {
            Account acct = new Account("1", 100);
            Console.WriteLine(acct.ToString());
            acct.withdraw(10);
            Console.WriteLine(acct.ToString());
            acct.deposit(3000);
            Console.WriteLine(acct.ToString());
        }
    }
}
