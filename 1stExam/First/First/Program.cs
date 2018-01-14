using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] number = input.ToCharArray();
            List<int> numbers = new List<int>();
            

            for (int i = number.Length - 1; i >= 0; i--)
            {
               
                numbers.Add(number[i] - '0');
            }
            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[numbers.Count-1]==-3)
                {
                    numbers.Remove(numbers[numbers.Count-1]);
                  
                }
            }

            int length = numbers.Count;
            BigInteger result = 0;
            result = CalcResult(numbers, length, result);
            Console.WriteLine(result);
            int startOfMessage = ((int)(result % 26)) + 1;
            var digits = new List<int>();
            result = DigitsOfResult(result, digits);
            BigInteger lengthOfmessage = 0;
            if (digits[digits.Count - 1] == 0)
            {
                Console.WriteLine("Big Vik wins again!");
            }
            else
            {
                lengthOfmessage = digits[digits.Count - 1];
            }


            for (int i = 0; i < lengthOfmessage; i++)
            {
                if ('@' + startOfMessage > 90)
                {
                    startOfMessage = 1;
                }
                Console.Write((char)('@' + startOfMessage));
                startOfMessage++;
            }
            Console.WriteLine();


        }

        private static BigInteger CalcResult(List<int> numbers, int length, BigInteger result)
        {
            for (int j = 0; j < length; j++)
            {
                int index = j + 1;
                if (index % 2 == 0)
                {
                    
                    result += ((BigInteger)Math.Pow(numbers[j], 2) * index);
                   
                }
                else
                {
                    result += ((BigInteger)Math.Pow(index, 2) * numbers[j]);
                }
            }

            return result;
        }

        private static BigInteger DigitsOfResult(BigInteger result, List<int> digits)
        {
            while (result > 0)
            {
                digits.Add((int)result % 10);
                result /= 10;
            }

            digits.Reverse();
            return result;
        }
    }
}
