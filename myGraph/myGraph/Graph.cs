using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGraph
{
    public class Graph
    {
        private int[,] vert;
        public Graph(int[,] vert)
        {
            this.Vert = vert;
        }
        public int[,] Vert { get { return this.vert; } set { this.vert = value; } }
        public void AddEdge(int i, int j)
        {
            Vert[i, j] = 1;
        }
        public void RemoveEdge(int i, int j)
        {
            Vert[i, j] = 0;
        }
        public bool HasEdge(int i, int j)
        {
            return Vert[i, j] == 1;
        }
        public IList<int> GetSuccessors(int i)
        {
            List<int> successors = new List<int>();
            for (int j = 0; j < Vert.GetLength(1); j++)
            {
                if (Vert[i,j]==1)
                {
                    successors.Add(j);
                }

            }
            return successors;
        }
    }
}
