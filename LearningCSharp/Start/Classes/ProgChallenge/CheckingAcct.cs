class CheckingAcct : Account
{
    private const decimal OVERDRAFT_CHARGE = 35.0m;
    public CheckingAcct(string firstName, string lastName, decimal intialBalance) : base(firstName, lastName, intialBalance)
    {

    }

    public override void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            amount += OVERDRAFT_CHARGE;
        }

        base.Withdraw(amount);
    }
}