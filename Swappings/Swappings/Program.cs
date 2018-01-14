using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] separators = input.Split(' ').Select(int.Parse).ToArray().ToArray();
            var linked = new LinkedList<int>();
            linked.AddFirst(1);
            linked.AddAfter(linked.First, 2);
            var next = linked.First.Next;
            for (int i = 3; i <= numbers; i++)
            {
                if (i == numbers)
                {
                    linked.AddLast(i);
                }
                else
                {
                    linked.AddAfter(next, i);

                }
                next = next.Next;

            }
            for (int i = 0; i < separators.Length; i++)
            {
                int x = separators[i];
                linked.Find(x);
                //Ako X e Purvo Chislo ! Works!
                if (linked.First.Value == x)
                {
                    linked.First.Value = linked.First.Next.Value;
                    linked.First.Next.Value = linked.First.Next.Next.Value;
                    linked.First.Next.Next.Value = linked.First.Next.Next.Next.Value;
                    linked.First.Next.Next.Next.Value = x;

                }
                //Ako X e Vtoro Chislo
                else if (linked.First.Next.Value == x)
                {
                    linked.First.Next.Value = linked.First.Next.Next.Value;
                    linked.First.Next.Next.Value = linked.First.Next.Next.Next.Value;
                    linked.First.Next.Next.Next.Value = linked.First.Next.Next.Next.Next.Value;
                    linked.First.Next.Next.Next.Next.Next.Value = linked.First.Value;
                    linked.RemoveFirst();
                    linked.First.Next.Next.Next.Next.Value = x;
                }
                //Ako X e Treto Chislo
                else if (linked.First.Next.Next.Value==x)
                    
                {
                    linked.First.Next.Value = linked.First.Next.Next.Value;
                    linked.First.Next.Next.Value = linked.First.Next.Next.Next.Value;

                    linked.First.Next.Next.Next.Value = linked.First.Next.Next.Next.Next.Value;
                    linked.First.Next.Next.Next.Next.Value = linked.First.Next.Next.Next.Next.Next.Value;
                    linked.First.Next.Next.Next.Next.Next.Value = x;
                }
                //Posledno
                else if (linked.Last.Value==x)
                {
                    linked.Last.Value = linked.Last.Previous.Value;
                    linked.Last.Previous.Value = linked.Last.Previous.Previous.Value;
                    linked.Last.Previous.Previous.Value = linked.Last.Previous.Previous.Previous.Value;
                    linked.Last.Previous.Previous.Previous.Value = x;

                }
                //Pred Posledno
                else if (linked.Last.Value == x)
                {
                    linked.Last.Previous.Value = linked.Last.Previous.Previous.Value;
                    linked.Last.Previous.Previous.Value = linked.Last.Previous.Previous.Previous.Value;
                    linked.Last.Previous.Previous.Previous.Value = linked.Last.Previous.Previous.Previous.Previous.Value;
                    linked.Last.Previous.Previous.Previous.Previous.Value = x;

                }
                //Pred pred Posledno
                else if (linked.Last.Value == x)
                {
                    linked.Last.Previous.Previous.Value = linked.Last.Previous.Previous.Previous.Value;
                    linked.Last.Previous.Previous.Previous.Value = linked.Last.Previous.Previous.Previous.Previous.Value;
                    linked.Last.Previous.Previous.Previous.Previous.Value = linked.Last.Previous.Previous.Previous.Previous.Previous.Value;
                    linked.Last.Previous.Previous.Previous.Previous.Previous.Value = x;

                }
                else
                {

                }

            }
            foreach (var item in linked)
            {
                Console.Write(item+" ");
                
            }
           





        }
    }
}
