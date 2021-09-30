namespace BankAccount.classes
{
    public class SavingAccount : Account
    {
        private double _interestRate;

        public SavingAccount(double interest, string owner, string devise) : base(owner, devise)
        {
            this._interestRate = interest;
        }
    }
}