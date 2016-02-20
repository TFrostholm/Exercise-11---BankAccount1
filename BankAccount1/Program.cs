using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Lønkonto");

            Console.WriteLine("The account {0} has a balance of DKK {1}", account1.AccountName, account1.GetAccountBalance()); 

            account1.Deposit(3500);

            Console.WriteLine("The account {0} has a balance of DKK {1}", account1.AccountName, account1.GetAccountBalance());

            account1.Withdraw(750);

            Console.WriteLine("The account {0} has a balance of DKK {1}", account1.AccountName, account1.GetAccountBalance());





            Console.ReadKey();
        }
    }
}
