using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            var linked = new MyLinked<int>();
            linked.AddFirst(1);
            linked.AddLast(2);
            linked.AddBefore(linked.First.Next, 4);
            Console.WriteLine(linked.ToString());


        }
    }
}
