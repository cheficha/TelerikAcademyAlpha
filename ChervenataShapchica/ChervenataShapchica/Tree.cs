using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChervenataShapchica
{
    public class Node
    {
        private int value;
        private IList<Node> neighbours;
        private bool visited;

        public Node(int value)
        {
            this.value = value;
            this.neighbours = new List<Node>();
            this.visited = false;
        }
        public int Value { get { return this.value; } set { this.value = value; } }
        public IList<Node> Neighbours { get { return this.neighbours; } set { this.neighbours = value; } }
        public bool Visited { get { return this.visited; } set { this.visited = value; } }

        public void AddNeigbhour(Node child)
        {
            this.neighbours.Add(child);
        }
        public Node GetChild(int index)
        {
            return this.neighbours[index];
        }

    }
    public class Tree
    {
      
        public Tree()
        {
            this.Graph = new Dictionary<Node, List<Node>>();
        }
        public Dictionary<Node, List<Node>> Graph { get; set; }



    }
}
