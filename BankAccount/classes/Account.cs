namespace BankAccount.classes
{
    public class Account
    {
        private int _balance = 0;
        private string _owner;
        private string _devise;

        protected Account(string owner, string devise)
        {
            _owner = owner;
            _devise = devise;
        }

        public void Credit(int amount)
        {
            _balance += amount;
        }

        public void Debit(int amount)
        {
            _balance -= amount;
        }

        public int getBalance()
        {
            return _balance;
        }

        public int getAccountId()
        {
            return 0;
        }
    }
}