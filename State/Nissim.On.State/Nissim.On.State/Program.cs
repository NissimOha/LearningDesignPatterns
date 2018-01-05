namespace Nissim.On.State
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Nissim");

            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);

            account.Withdraw(1400.00);
            account.Withdraw(1100.00);

            account.Deposit(1500.0);
            account.Deposit(100000.0);
        }
    }
}
