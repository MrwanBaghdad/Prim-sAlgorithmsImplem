using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prim_s_Algorithm
{
    static class Prim
    {
        public static List<edges> minSpanningTree = new List<edges>();

        public static void findMinSpanningTree()
        {
            node.AllNodes[0].visited = true;
            while (node.AllNodes.Any(n => n.visited == false))
            {
                List<edges> visNodesEdges = new List<edges>();
                visNodesEdges.AddRange(edges.allEdges.FindAll(e=> (e.n2.visited==false && e.n1.visited==true) || (e.n2.visited==true && e.n1.visited==false) ));
                edges minEdge = visNodesEdges.Find(a1 => a1.weight == visNodesEdges.Min(a2 => a2.weight));
                minEdge.n2.visited = true;
                minEdge.n1.visited = true;
                minSpanningTree.Add(minEdge);
                // TODO: make the graph undirected
                // TODO: Graph could be not connected 
            }
        }
    }
}
