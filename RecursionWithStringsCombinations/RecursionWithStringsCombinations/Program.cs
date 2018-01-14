using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionWithStringsCombinations
{
    class Program
    {
        static int n;
        static int k;
        static string[] strings;
        static List<string> Printings;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            strings = new string[n];
            Printings = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                strings[i] = input;
            }
            Combinations(0);

        }
        public static void Combinations(int number)
        {
            if (Printings.Count==k)
            {
                Print();
                return;
            }
            for (int i = 0; i < n ; i++)
            { 
                Printings.Add(strings[i]);
                Combinations(number + 1);
                Printings.RemoveAt(Printings.Count-1);
            }
        }
        public static void Print()
        {
            
            foreach (var item in Printings)
            {
                Console.Write(item+' ');
            }
            Console.WriteLine();
        }
    }
}
