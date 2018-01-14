using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var sum = 0;
            bool check = true;
            while (check != false)
            {
                string element = Console.ReadLine();
                
              check= int.TryParse(element,out Int32 num);
               if (check==true)
                {
                    list.Add(int.Parse(element));
                }
                
                
            }
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }
    }
}
