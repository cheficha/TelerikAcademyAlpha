using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTriangleSecond
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            if (number<=3)
            {
                return true;
            }
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int j = 1; j <= N; j++)
            {
                if (IsPrime(j))
                {
                    numbers.Add(j);
                }


            }
            foreach (int item in numbers)
            {
                for (int i = 1; i <=item; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write(1);
                    }
                   
                }
                Console.WriteLine();

            }
           
        }
    }
}
