class SavingsAcct : Account
{

    decimal _interest;
    int _withdrawalCount;
    private const int WITHDRAWAL_LIMIT = 3;
    private const decimal WITHDRAWAL_CHARGE = 2.0m;

    public SavingsAcct(string firstName, string lastName, decimal interest, decimal intialBalance) : base(firstName, lastName, intialBalance)
    {
        _interest = interest;
    }

    public void ApplyInterest()
    {
        Balance += Balance * _interest;
    }

    public override void Withdraw(decimal amount)
    {
        decimal newBalance = Balance - amount;
        if (amount > Balance)
        {
            System.Console.WriteLine("Sorry, there is not enough money in the account.");
            return;
        }

        if (_withdrawalCount >= WITHDRAWAL_LIMIT)
        {
            amount += WITHDRAWAL_CHARGE;
        }

        base.Withdraw(amount);
        _withdrawalCount++;
    }
}