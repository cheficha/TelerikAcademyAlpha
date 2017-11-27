using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace IntOperationsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
           
            minimumNumber(numbers);
            maxNumber(numbers);
            averageOfNums(numbers);
            sumOfNumbers(numbers);
            productOfNumbers(numbers);
        }

        private static void productOfNumbers(string numbers)
        {
            int[] theNumbers = numbers.Split(' ').Select(int.Parse).ToArray();
            BigInteger product = 1;
            for (int i = 0; i < theNumbers.Length; i++)
            {
                product *= theNumbers[i];
            }
            Console.WriteLine(product);

        }

        private static void averageOfNums(string numbers)
        {
            double [] theNumbers = numbers.Split(' ').Select(double.Parse).ToArray();
            double average = 0;
            
           
            for (int i = 0; i < theNumbers.Length; i++)
            {
                average += theNumbers[i];
            }
           

           
            average = average / 5;
            Console.WriteLine("{0:0.00}",average);
           

        }

        private static void sumOfNumbers(string numbers)
        {
            int[] theNumbers = numbers.Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < theNumbers.Length; i++)
            {
                sum += theNumbers[i];
            }
            Console.WriteLine(sum);
        }

        private static void maxNumber(string numbers)
        {
            int[] theNumbers = numbers.Split(' ').Select(int.Parse).ToArray();
            int maximum = theNumbers[0];
            for (int i = 0; i < theNumbers.Length; i++)
            {
                if (maximum <= theNumbers[i])
                {
                    maximum = theNumbers[i];
                }

            }
            Console.WriteLine(maximum);

        }

        private static void minimumNumber(string numbers)
        {
            int[] theNumbers = numbers.Split(' ').Select(int.Parse).ToArray();
            int minimum = theNumbers[0];
            for (int i = 0; i < theNumbers.Length; i++)
            {
                if (minimum>theNumbers[i])
                {
                    minimum = theNumbers[i];
                }

            }
            Console.WriteLine(minimum);
        }
    }
}
