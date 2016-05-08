using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prim_s_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //nodes
            node n1 = new node();
            node n2 = new node();
            node n3 = new node();
            node n4 = new node();
            //edges
            new edges(n1, n2, 2,1);
            new edges(n2, n3, 1, 1);
            new edges(n3, n4, 3, 1);
            new edges(n1, n3, 0, 1);
            new edges(n1, n4, 0, 1);
            Prim.findMinSpanningTree();
            foreach (edges x in Prim.minSpanningTree)
            {
                Console.WriteLine("{0} {1}", x.ToString(), x.weight);
            }
            Console.ReadLine();
        }
    }
}
