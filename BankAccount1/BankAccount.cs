namespace BankAccount1
{
    public class BankAccount
    {
        public double Balance;
        public string AccountName;

        public BankAccount(string accountName)
        {
            Balance = 0.0;
            AccountName = accountName;
        }

        public void Deposit(int amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(int amount)
        {
            Balance = Balance - amount;
        }

        public double GetAccountBalance()
        {
            return Balance;
        }

        public string GetAccountName()
        {
            return AccountName;
        }


    }
}