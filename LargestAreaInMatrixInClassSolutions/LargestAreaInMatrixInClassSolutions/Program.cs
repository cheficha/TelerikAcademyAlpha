using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAreaInMatrixInClassSolutions
{
    class Program
    {
        private static int[] Rows = { 1, -1, 0, 0 };
        private static int[] Cols = { 0, 0, -1, 1 };

        static void Main(string[] args)
        {
            var rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToList();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] graph = new int[rows, cols];
            bool[,] visited = new bool[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                var row = Console.ReadLine().Split().Select(int.Parse).ToList();
                for (int j = 0; j < cols; j++)
                {
                    graph[i, j] = row[j];
                }
                var largest = 0;
                for (int si= 0; si < rows; si++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (!visited[si,j])
                        {
                            int area = BFS(si,j,graph,visited);

                        }
                    }
                }
            }


        }
        private static int BFS(int row , int col, int [,]graph,bool [,]visited)
        {
            int count = 0;
            Node startNode = new Node() { Row= row,Col=col};
            visited[startNode.Row, startNode.Col] = true;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(startNode);
            while (queue.Count>0)
            {
                Node node = queue.Dequeue();
                count++;
                foreach (Node  neighbour in GetNeighbours(node.Row,node.Col,graph))
                {
                    if (!visited[neighbour.Row,neighbour.Col])
                    {
                        queue.Enqueue(neighbour);
                        visited[startNode.Row, startNode.Col] = true;

                    }
                }

            }
            return count;
        }
        private static IEnumerable<Node> GetNeighbours(int row, int col, int[,] graph)
        {
            List<Node> neighbours = new List<Node>();
            for (int i = 0; i < Rows.Length; i++)
            {
                Node node = new Node()
                {
                    Row = row + Rows[i],
                    Col = col + Cols[i]
                };
                if (IsValid(row + Rows[i], col + Cols[i], graph.GetLength(0), graph.GetLength(1)) && graph[row, col] == graph[node.Row, node.Col])
                {
                    neighbours.Add(node);

                }

            }
            return neighbours;
        }
        private static bool IsValid(int row, int col, int rows, int cols)
        {
            return row > -1 && row < rows && col > -1 && col < cols;

        }
    }
    public class Node
    {
        public int Row { get; set; }
        public int Col
        { get; set; }

    }
}
