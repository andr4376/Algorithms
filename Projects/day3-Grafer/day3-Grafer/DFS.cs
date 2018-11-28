using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_Grafer
{
    //DFS = STACK ALGORITME BFS = QUEUE
    class DFS
    {

        public static void FindPath(int target)
        {
            Stack<Edge> stack = new Stack<Edge>();

            List<Node> visitedNodes = new List<Node>();

            stack.Push(new Edge(Program.graph.nodes["Node #1"], Program.graph.nodes["Node #1"]));

            while (stack.Count > 0)
            {
                Edge currentEdge = stack.Pop();
                Console.WriteLine(currentEdge);


                if (currentEdge.visited == false)
                {
                    currentEdge.visited = true;


                    visitedNodes.Add(currentEdge.backNode);

                   

                    foreach (Edge edge in currentEdge.forwardNode.edges)
                    {
                        stack.Push(edge);
                    }

                    if (currentEdge.forwardNode.Value == target)
                    {

                        Console.WriteLine("target found");

                        foreach (Node _node in visitedNodes)
                        {
                            Console.WriteLine(_node.ToString());
                        }

                        break;
                    }
                }



            }
        }

    }
}
