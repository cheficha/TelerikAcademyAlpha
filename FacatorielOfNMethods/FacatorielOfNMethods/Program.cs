using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FacatorielOfNMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            getFactoriel(number);
        }

        private static void getFactoriel(int number)
        {
            if (number==0)
            {
                Console.WriteLine("1");
            }
            if (number>0)
            {

            
           BigInteger fact = number;
            for (int i = 1; i < number; i++)
            {
                fact = fact * i;
            }
           
            
                Console.WriteLine(fact);
            }
           else if (number<0)
            {
                int fact = Math.Abs(number);
                BigInteger result = fact;
                for (int i = 1; i < fact; i++)
                {
                    result = result * i;
                }
                Console.WriteLine("-{0}",result);
            }
        }
    }
}
