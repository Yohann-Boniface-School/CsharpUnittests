namespace BankAccount.classes
{
    public class Account
    {
        private static int _instanceCount;

        private readonly int _id; 
        private int _balance;
        private string _owner;
        private string _devise;
        
        public Account(string owner, string devise, int balance = 0)
        {
            _id = ++_instanceCount;
            
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

        public int GetBalance()
        {
            return _balance;
        }

        public int GetAccountId()
        {
            return _id;
        }
    }
}