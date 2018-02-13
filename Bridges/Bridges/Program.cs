using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridges
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var vertCount = input[0];
            var edgeCount = input[1];
            var graph = new UndirectedGraph();
            for (int i = 0; i < edgeCount; i++)
            {
                var theInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var first = theInput[0];
                var second = theInput[1];
                var weight = theInput[2];
                graph.AddVertex(first);
                graph.AddVertex(second);
            


            }
            var busWeight = int.Parse(Console.ReadLine());
            var result = Calc(graph, busWeight);
            Console.WriteLine(result);

        }
        private static int Calc(UndirectedGraph graph, int weight)
        {
            var counter = 0;


            return counter - 1;
        }
    }
    class Vertex
    {
        public Vertex(int value)
        {
            this.Value = value;
            this.Links = new Dictionary<int, Edge>();
        }

        public int Value { get; set; }

        public bool IsVisited { get; set; }

        public Dictionary<int, Edge> Links { get; set; }
    }

    class UndirectedGraph
    {
        public UndirectedGraph()
        {
            this.Vertex = new Dictionary<int, Vertex>();
        }

        public Dictionary<int, Vertex> Vertex { get; set; }


        public void AddVertex(int n)
        {
            if (!this.Vertex.ContainsKey(n))
            {
                this.Vertex.Add(n, new Vertex(n));
            }
        
        }

        public void AddConnection(int start, int target, int weight)
        {
            var startNode = this.Vertex[start];
            var targetNode = this.Vertex[target];

            var link = new Edge(weight, targetNode);

            if (startNode.Links.ContainsKey(target))
            {
                if (startNode.Links[target].Weight > weight)
                {
                    startNode.Links[target] = link;
                }
            }
            else
            {
                startNode.Links.Add(target, link);
            }
        }

    }

    class Edge
    {
        public Edge(int weight, Vertex target)
        {
            this.Weight = weight;
            this.Target = target;
        }

        public int Weight { get; set; }

        public Vertex Target { get; set; }
    }
}
