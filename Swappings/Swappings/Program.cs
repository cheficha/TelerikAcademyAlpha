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
           var separators = Console.ReadLine().Split(' ').Select(int.Parse).ToArray().ToArray();
            var dict = new Dictionary<int, Node>();
            var list = new List<Node>();
            
            for (int i = 1; i <=numbers; i++)
            {
                if (i==1)
                {
                    dict.Add(i, new Node { Value = i, Previous = null });
                }
                else if (i==numbers)
                {
                dict.Add(i,new Node { Value=i,Previous=dict[i-1],Next=null});
                    if (dict[i].Previous != null)
                    {
                        dict[i - 1].Next = dict[i];
                    }
                }
                else if (i-1>0)
                {
                    
                        dict.Add(i, new Node { Value = i, Previous = dict[i - 1]});
                    
                    if (dict[i].Previous != null)
                    {
                        dict[i - 1].Next = dict[i];
                    }
                   
                }
              
            }///Dict and Next + Previous Assing

            Node head = dict[1];
            Node tail = dict[numbers];
            for (int i = 0; i < separators.Length; i++)
            {
                var n = separators[i];
          
                if (dict[n]==tail)
                {
                    Node Come = tail;
                    Node On = head;
                    tail = tail.Previous;
                    head = Come;
                    Come.Next = On;
                    tail.Next = null;
                    

                }
                else if (dict[n]==head)
                {
                    Node Come = tail;
                    Node On = head;
                    head = head.Next;
                    tail = On;
                    tail.Previous = Come;
                    Come.Next = tail;
                    tail.Next = null;
                }
                else
                {
                    var TempNext = dict[n].Next;
                    var tempHead = head;
                    var tempTail = tail;

                    tail = dict[n].Previous;
                    head = dict[n].Next;

                    dict[n].Next = tempHead;
                    dict[n].Previous = tempTail;
                    tempHead.Previous = dict[n];
                    tempTail.Next = dict[n];

                    }

        }

            tail.Next = null;
            head.Previous = null;
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
            }
          
          
    }
    public class Node
    {
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public int Value { get; set; }
       
    }
}
