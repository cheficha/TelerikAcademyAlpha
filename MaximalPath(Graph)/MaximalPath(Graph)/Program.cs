﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace MaxPath
{
    public class Graph
    {
        private Dictionary<int, List<int>> nodes;
        public Graph()
        {
            this.nodes = new Dictionary<int, List<int>>();
        }
        public void AddConnection(int x, int y)
        {
            this.AddEdge(x, y);
            this.AddEdge(y, x);
        }
        private void AddEdge(int from, int to)
        {
            if (!(this.nodes.ContainsKey(from)))
            {
                this.nodes[from] = new List<int>();
            }
            this.nodes[from].Add(to);
        }
        public BigInteger MaxPath()
        {
            var start = this.nodes.Keys.FirstOrDefault(key => this.nodes[key].Count == 1);
            var firstBest = this.Dfs(start, start, -1);
            var best = this.Dfs((int)firstBest[0], firstBest[0], -1);
            return best[1];
        }
        private BigInteger[] Dfs(int node, BigInteger path, int parent)
        {
            var bestNode = node;
            var bestPath = path;
            this.nodes[node]
                .ForEach((nextNode) =>
                {
                    if (nextNode == parent)
                    {
                        return;
                    }
                    var newRes = this.Dfs(nextNode, path + nextNode, node);
                    var newNode = newRes[0];
                    var newPath = newRes[1];
                    if (newPath > bestPath)
                    {
                        bestPath = newPath;
                        bestNode = (int)newNode;
                    }
                });
            return new BigInteger[] { bestNode, bestPath };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var graph = new Graph();
            Enumerable.Range(0, n - 1)
                      .Select((x) => Console.ReadLine()
                              .Split(new char[] { '(', ')', '<', '-' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(y => y.Trim())
                              .Select(int.Parse)
                              .ToList()
                      )
                      .ToList()
                      .ForEach((edge) =>
                      {
                          graph.AddConnection(edge[0], edge[1]);
                      });
            Console.WriteLine(graph.MaxPath());
        }
    }
}