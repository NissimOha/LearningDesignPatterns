using System;

namespace Nissim.On.State.ConcreteState
{
    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class RedState : AccountState
    {
        public RedState(AccountState p_state):base(p_state.Balance, p_state.Account)
        {
            Init();
        }

        private void Init()
        {
            LowerLimit = -100.0;
            UpperLimit = 1000.0;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            if(Balance - amount >= LowerLimit)
                Balance -= amount;
            else
                Console.WriteLine("No funds available for withdrawal!");
        }

        private void StateChangeCheck()
        {
            if(Balance > 1000.0)
            {
                Account.ChangeState(new GoldState(this));
            }
            else if (Balance > UpperLimit)
            {
                Account.ChangeState(new SilverState(this));
            }
        }
    }
}
