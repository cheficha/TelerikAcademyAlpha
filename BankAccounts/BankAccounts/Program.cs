using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public delegate void MyDel(decimal param);

    class Program
    {
        static void Main(string[] args)
        {

            var chefichaAccount = new DepositAccount(CustomerTYPE.individual,0,5);
            MyDel del = new MyDel(chefichaAccount.Deposit);


            chefichaAccount.Deposit(100000);
            chefichaAccount.CalculateInterest(12);
            Console.WriteLine( chefichaAccount.Print());
        }
    }
}
