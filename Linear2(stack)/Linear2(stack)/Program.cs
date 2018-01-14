using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear2_stack_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int [] ints = input.Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            for (int i = ints.Length - 1; i >= 0; i--)
            {
                stack.Push(ints[i]);
                Console.WriteLine(stack.Peek());
            }
        }
    }
}
