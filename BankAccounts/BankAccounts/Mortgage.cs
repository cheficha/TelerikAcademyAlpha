using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Mortgage : Account
    {
        public Mortgage(CustomerTYPE customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

    }
}
