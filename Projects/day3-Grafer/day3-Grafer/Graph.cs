using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_Grafer
{
    class Graph
    {
       // public List<Node> nodes = new List<Node>();

       public Dictionary<string, Node> nodes = new Dictionary<string, Node>();

        public void AddNode(string name,Node node)
        {
            nodes.Add(name,node);

        }
    }
}
