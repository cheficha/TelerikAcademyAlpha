using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetOfStringRecursion
{
    class Program
    {
        static int n;
        static string[] strings;
        public static bool[] used;

        static List<string> Printings;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            used = new bool[n+1];
            Printings = new List<string>();
            strings = input.Split(',');
            Combinations(n);

        }
        public static void Combinations(int number, int start = 0)
        {
            if (Printings.Count == n)
            {
                Print();
                return;
            }
            for (int i = start; i < strings.Length; i++)
            {
                if (used[i] == false)
                {
                    used[i] = true;
                    Printings.Add(strings[i]);
                    Combinations(number + 1,i);
                    used[i] = false;

                    Printings.RemoveAt(Printings.Count - 1);

                }


            }
        }
        public static void Print()
        {

            foreach (var item in Printings)
            {

                Console.Write(item + ' ');
            }
            Console.WriteLine();
        }
       
    }
}

