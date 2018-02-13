using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineAreaInMatrix
{
    class Program
    {
        static int[] Rows = { 1, -1, 0, 0 };
        static int[] Cols = { 0, 0, -1, 1 };

        static bool[,] used;
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] graph = new int[rows, cols];
            used = new bool[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                var z = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    graph[i, j] = z[j];
                }

            }
            int largest = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!used[i, j])
                    {
                        int area = BFS(i, j, graph, used);
                        if (area > largest)
                        {
                            largest = area;
                        }
                    }

                }
            }
            Console.WriteLine(largest);

        }
        //public static int BFS(int row, int col, int[,] graph, bool[,] visited)
        //{
        //    var count = 0;
        //    Node startNode = new Node { Row=row,Col=col};
        //    visited[startNode.Row,startNode.Col] = true;
        //    Queue < Node > queue= new Queue<Node>();
        //    queue.Enqueue(startNode);
        //    while (queue.Count>0)
        //    {
        //        Node node = queue.Dequeue();
        //        count++;
        //        foreach (Node item in GetNeighbours(node.Row,node.Col,graph))
        //        {
        //            if (!visited[item.Row,item.Col])
        //            {
        //                queue.Enqueue(item);
        //                visited[item.Row, item.Col] = true;
        //            }
        //        }
        //    }


        //    return count;
        //}
        public static void DFS(int row,int col, int [,]graph,bool [,]visited)
        {

        }
        public static IEnumerable<Node> GetNeighbours(int row, int col, int[,] graph)
        {
            List<Node> neigbhours = new List<Node>();
            for (int i = 0; i < Rows.Length; i++)
            {
                Node node = new Node() { Row = row + Rows[i], Col = col + Cols[i] };
                if (IsValid(node.Row, node.Col, graph) && graph[row, col] == graph[node.Row, node.Col])
                {
                    neigbhours.Add(node);
                }

            }
            return neigbhours;
        }
        public static bool IsValid(int row, int col, int[,] graph)
        {
            if (row < 0 && col < 0 && row > graph.GetLength(0) - 1 && col > graph.GetLength(1) - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    public class Node
    {
        public int Row { get; set; }
        public int Col { get; set; }

    }
}
