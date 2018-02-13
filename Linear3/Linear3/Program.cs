using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
           
            bool check = true;
            while (check!=false)
            {
                var element = Console.ReadLine();
                check = int.TryParse(element,out int num);
                if (check==true)
                {
                    list.Add(int.Parse(element));
                }
            }
            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
