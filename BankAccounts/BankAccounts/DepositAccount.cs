using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class DepositAccount : Account
    {
        
       
        public DepositAccount(CustomerTYPE customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override AccountTypes Type { get { return this.Type = AccountTypes.deposit; } }
        public override  void CalculateInterest(int months)
        {
            if (this.Balance<=1000)
            {
                throw new ArgumentException("YOU HAVE NO INTEREST ");
            }
            else
            {
                this.Interest= months *(this.Balance/100/this.InterestRate);
            }
        }
        public void Withdraw(int amount)
        {
            this.Balance -= amount;
        }


    }
}
