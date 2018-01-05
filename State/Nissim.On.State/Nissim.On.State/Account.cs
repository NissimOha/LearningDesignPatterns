using Nissim.On.State.ConcreteState;
using System;

namespace Nissim.On.State
{
    /// <summary>.
    /// The 'Context' class.
    /// </summary>
    class Account
    {
        public AccountState State { get; private set; }
        public string Owner { get; private set; }
        public double Balance { get { return State.Balance; } }

        public Account(string p_owner)
        {
            Owner = p_owner;
            State = new SilverState(0.0, this);
        }

        public void ChangeState(AccountState p_state)
        {
            State = p_state;
        }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine("Deposited {0}$ --- ", amount);
            Console.WriteLine(" Balance = {0}$", Balance);
            Console.WriteLine(" Status = {0}", State.GetType().Name + "\n");
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("Withdrew {0}$ --- ", amount);
            Console.WriteLine(" Balance = {0}$", Balance);
            Console.WriteLine(" Status = {0}\n", State.GetType().Name);
        }
    }
}
