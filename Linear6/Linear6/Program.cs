using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear6
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = input.Split(' ').Select(int.Parse).ToList();
            var distinct = list.Distinct<int>().ToList();
            for (int i = 0; i < distinct.Count; i++)
            {
                int num = list.Where(x => x == distinct[i]).Count();
                if (num%2!=0)
                {
                    list = list.Where(x => x != distinct[i]).ToList();
                }

            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
       
        }
    }
}
