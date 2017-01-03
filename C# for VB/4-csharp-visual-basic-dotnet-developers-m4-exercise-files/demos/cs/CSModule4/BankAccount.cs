using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSModule4
{
    public class TransactionEventArgs : EventArgs
    {
        public string Message { get; set; }

        public TransactionEventArgs(string message)
        {
            this.Message = message;
        }
    }

    public class BankAccount
    {
        public event EventHandler<TransactionEventArgs> LargeWithdrawl;
        public event EventHandler<TransactionEventArgs> WithdrawlExceedsBalance;

        private decimal _balance;

        public BankAccount(decimal balance)
        {
            this._balance = balance;
        }

        public bool Withdraw(decimal amount)
        {
            if (this._balance < amount)
            {
                this.OnWithdrawlExceedsBalance();
                return false;
            }

            this._balance -= amount;

            Console.WriteLine("{0:c} is withdrawn from the acount.", amount);

            if (amount >= 1000)
            {
                this.OnLargeWithdrawl();
            }

            return true;
        }

        private void OnWithdrawlExceedsBalance()
        {
            if (this.WithdrawlExceedsBalance != null)
            {
                this.WithdrawlExceedsBalance(this, 
                    new TransactionEventArgs("Withdrawl denied. Exceeds balance."));
            }
        }

        private void OnLargeWithdrawl()
        {
            if (this.LargeWithdrawl != null)
            {
                this.LargeWithdrawl(this,
                    new TransactionEventArgs("ATTENTION: Large withdrawl - call your teenager and see what's up!"));
            }
        }
    }
}
