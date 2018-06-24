using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChervenataShapchica
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numOfNodes = int.Parse(Console.ReadLine());
            var values = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arrOfNodes = new Node[numOfNodes + 1];
            for (int i = 0; i < values.Length; i++)
            {
                var node = new Node(values[i]);
                arrOfNodes[i + 1] = node;
            }
            for (int i = 1; i < numOfNodes; i++)
            {
                var connections = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var firstNode = connections[0];
                var secondNode = connections[1];
                arrOfNodes[firstNode].AddNeigbhour(arrOfNodes[secondNode]);
                arrOfNodes[secondNode].AddNeigbhour(arrOfNodes[firstNode]);
            }

            Console.WriteLine();
     
        }
      
    }
}
