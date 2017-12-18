using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    interface IAccount
    {
        CustomerTYPE Customer { get; }
        AccountTypes Type { get;}
        decimal Balance { get;  }
        decimal InterestRate { get;}

    }
}
