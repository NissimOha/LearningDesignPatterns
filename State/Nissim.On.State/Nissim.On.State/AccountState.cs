namespace Nissim.On.State
{
    /// <summary>
    /// The 'State' Abstruct class
    /// </summary>
    abstract class AccountState
    {
        public Account Account { get; set; }
        public double Balance { get; set; }
        public double LowerLimit { get; set; }
        public double UpperLimit { get; set; }

        public AccountState(double p_balance, Account p_account)
        {
            Account = p_account;
            Balance = p_balance;
        }
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
    }
}
