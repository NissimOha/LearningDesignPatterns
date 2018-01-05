using System;

namespace Nissim.On.State.ConcreteState
{
    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class GoldState : AccountState
    {
        public GoldState(AccountState p_state) : base(p_state.Balance, p_state.Account)
        {
            Init();
        }

        private void Init()
        {
            LowerLimit = 1000.0;
            UpperLimit = 100000.0;
        }

        public override void Deposit(double amount)
        {
            if(Balance + amount <= UpperLimit)
                Balance += amount;
            else
                Console.WriteLine("Our Bank can't deal with you!");
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= LowerLimit - 1100)
            {
                Balance -= amount;
                StateChangeCheck();
            }
            else
                Console.WriteLine("No funds available for withdrawal!");
        }

        private void StateChangeCheck()
        {
            if (Balance < 0.0)
            {
                Account.ChangeState(new RedState(this));
            }
            else if (Balance < LowerLimit)
            {
                Account.ChangeState(new SilverState(this));
            }
        }
    }
}
