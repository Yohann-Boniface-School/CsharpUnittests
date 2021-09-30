namespace BankAccount.classes
{
    public class SavingAccount : Account
    {
        private double _interestRate;

        public SavingAccount(
            double interest, string owner, string devise, int balance = 0
        ) : base(owner, devise, balance)
        {
            this._interestRate = interest;
        }
    }
}