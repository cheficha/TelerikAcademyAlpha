using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPermutationsOfNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int counter = 0;
            var digits = new List<int>();
            var used = new Dictionary<int, bool>();
            
            var sb = new StringBuilder();
            var result = new List<string>();
            while (counter != num)
            {
                Console.Write("Enter element {0} : ", counter + 1);
                digits.Add(int.Parse(Console.ReadLine()));
                counter++;
            }
            for (int i = 0; i < digits.Count; i++)
            {
                used.Add(digits[i], false);
            }
            AllPermutations(digits,used,sb,result);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        public static void AllPermutations(List<int> list,Dictionary<int, bool> used,StringBuilder sb,List<string>result)
        {
            if (sb.Length==list.Count)
            {
                result.Add(sb.ToString().Trim());
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (used[list[i]]==false)
                {
                    used[list[i]] = true;
                    sb.Append($"{list[i]}");
                    AllPermutations(list, used, sb, result);
                    sb.Remove(0,sb.Length-1);
                    used[list[i]] = false;

                }
               
            }
        }
    }
}
