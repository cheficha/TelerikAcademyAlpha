using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AscendingArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Take(n).Select(int.Parse).ToArray();
            AscendingNumbers(n,arr);
        }

        private static void AscendingNumbers(int size,int [] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write("{0}", arr[i]);
                }
                else
                {


                    Console.Write("{0} ", arr[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
