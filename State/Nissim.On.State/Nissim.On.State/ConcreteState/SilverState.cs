using System;

namespace Nissim.On.State.ConcreteState
{
    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class SilverState : AccountState
    {
        public SilverState(AccountState p_state) : base(p_state.Balance, p_state.Account)
        {
            Init();
        }

        public SilverState(double balance, Account account) : base(balance, account)
        {
            Init();
        }

        private void Init()
        {
            LowerLimit = 0.0;
            UpperLimit = 1000.0;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= LowerLimit - 100)
            {
                Balance -= amount;
                StateChangeCheck();
            }
            else
                Console.WriteLine("No funds available for withdrawal!");
        }

        private void StateChangeCheck()
        {
            if (Balance < LowerLimit)
            {
                Account.ChangeState(new RedState(this));
            }
            else if (Balance > UpperLimit)
            {
                Account.ChangeState(new GoldState(this));
            }
        }
    }
}
