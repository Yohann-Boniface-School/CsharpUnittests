namespace BankAccount.classes
{
    public class Account
    {
        private int _balance;
        private string _owner;
        private string _devise;
        
        protected Account(string owner, string devise, int balance = 0)
        {
            _owner = owner;
            _devise = devise;
            _balance = balance;
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