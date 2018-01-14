using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationAlgorithm
{
    class Program
    {
        public static int n;
        public static int[] arr;
        public static int[] newArr;
        public static bool[] used;


        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            arr = new int[n];
            used = new bool[n + 1];

            Per();
      
        }
       

        public static void Per(int index = 0)
        {
            if(index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int number = 1; number < arr.Length + 1; number++)
            {
                if (used[number] == false)
                {
                    used[number] = true;
                    arr[index] = number;
                    Per(index + 1);
                    used[number] = false;
                }
            }
        }
    }
}
