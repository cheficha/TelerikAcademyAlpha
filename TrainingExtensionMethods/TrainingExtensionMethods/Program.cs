using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();
            //int i = text.WordsCount();
            //Console.WriteLine(i);
            var list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            list.IncreaseElements(7);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
