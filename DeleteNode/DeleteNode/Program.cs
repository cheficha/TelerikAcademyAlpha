using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteNode
{
    class Program
    {
        static void Main(string[] args)
        {
            var linked = new LinkedList<int>();
            linked.AddFirst(1);
            linked.AddAfter(linked.First, 2);
            linked.AddBefore(linked.Last, 3);
            linked.AddLast(4);
            var value=linked.Find(3);
            linked.Remove(value);
            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }

        }
    }
}
