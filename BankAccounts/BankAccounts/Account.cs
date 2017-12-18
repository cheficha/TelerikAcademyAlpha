using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{

    public abstract class Account : IAccount
    {
        private CustomerTYPE customer;
        private  AccountTypes type;
        private decimal balance;
        private decimal interestRate;
        private decimal interest;
        public Account(CustomerTYPE customer,decimal balance,decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;

        }
        public CustomerTYPE Customer { get { return this.customer; } }
        public virtual AccountTypes Type { get { return this.type; }protected set { this.type = value; } }
        public decimal Balance { get { return this.balance; } protected set { this.balance = value; } }
        public decimal InterestRate { get { return this.interestRate; } }
        public decimal Interest { get { return this.interest; }protected set {this.interest=value; } }
        public virtual void Deposit(decimal amount)
        {
                this.Balance += amount;
            
         }
       
        public virtual void  CalculateInterest(int months)
        {
          this.Interest  = months * (this.Balance / this.InterestRate);
        }
        public string Print()
        {
            var SB = new StringBuilder();
            SB.Append(this.Type);
            SB.AppendLine();
            SB.Append(this.Balance);
            SB.AppendLine();
            SB.Append(this.Interest);
            return SB.ToString();
        }





    }
}
