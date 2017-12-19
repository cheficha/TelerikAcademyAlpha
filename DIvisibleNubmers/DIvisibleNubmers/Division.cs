using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvisibleNubmers
{
    public static class Division
    {
        public static void Divisible(this Numbers numbers)
        {
            var divisions = numbers.AllNumbers
                .Where(x => x % 3 == 0);
            var anotherdivisions = numbers.AllNumbers
                .Where(x=>x%7==0);
            Console.WriteLine("Numbers divisible by 3: ");
            foreach (int item in divisions)
            {
                
                Console.WriteLine(item);
            }
            Console.WriteLine("Numbers divisible by 7: ");
            foreach (int item in anotherdivisions)
            {
              
                Console.WriteLine(item);
            }

        }
    }
}
