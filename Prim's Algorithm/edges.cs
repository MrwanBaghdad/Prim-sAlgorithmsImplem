using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prim_s_Algorithm
{
    class edges 
    {
        public int weight;
        public node n1;
        public node n2;
        public static List<edges> allEdges = new List<edges>();
        public edges(node n1, node n2,int weight,int n)
        {
            this.weight = weight;
            this.n1 = n1;
            this.n2 = n2;
            n2.adjList.Add(this);
            allEdges.Add(this);
            n--;
            if(n>=0)
                new edges(n2, n1, weight,0);
        }
    }
}
