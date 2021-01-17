using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("ankan", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            var account2 = new BankAccount("tousif", 10000);
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");

            account2.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account2.Balance);
            account2.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account2.Balance);

            Console.WriteLine(account2.GetAccountHistory());
        }
    }
}


/*

  This bank account supports following behaviors:

* It has a 10-digit number that uniquely identifies the bank account.
* It has a string that stores the name or names of the owners.
* The balance can be retrieved.
* It accepts deposits.
* It accepts withdrawals.
* The initial balance must be positive.
* Withdrawals cannot result in a negative balance.

*/