using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prim_s_Algorithm
{
    class node
    {
        public List<edges> adjList= new List<edges>();
        public static List<node>AllNodes= new List<node>();
        public bool visited=false;
        public node()
        {
            AllNodes.Add(this);
        }
    }
}
