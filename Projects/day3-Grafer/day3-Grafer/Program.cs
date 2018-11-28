using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_Grafer
{
    class Program
    {
        static Random rnd = new Random();
        public static Graph graph = new Graph();

        static void Main(string[] args)
        {
            //TestGraph();

            for (int i = 1; i <= 10; i++)
            {
                graph.AddNode("Node #" + i, new Node(i));

            }

            graph.nodes["Node #1"].MakeConnection(graph.nodes["Node #2"], false);
            graph.nodes["Node #1"].MakeConnection(graph.nodes["Node #3"], false);
            graph.nodes["Node #1"].MakeConnection(graph.nodes["Node #4"], false);
            graph.nodes["Node #2"].MakeConnection(graph.nodes["Node #5"], false);
            graph.nodes["Node #5"].MakeConnection(graph.nodes["Node #9"], false);
            graph.nodes["Node #3"].MakeConnection(graph.nodes["Node #6"], false);
            graph.nodes["Node #4"].MakeConnection(graph.nodes["Node #6"], false);
            graph.nodes["Node #4"].MakeConnection(graph.nodes["Node #7"], false);
            graph.nodes["Node #7"].MakeConnection(graph.nodes["Node #8"], false);








            //for (int i = 0; i < 10; i++)
            //{
            //    Node node = new Node(i);
            //    graph.AddNode("Node #" + i, node);




            //    if (i != 0 && graph.nodes["Node #" + (i - 1)] != null)
            //    {
            //        graph.nodes["Node #" + (i - 1)].MakeConnection(node, false);
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    int from = rnd.Next(0, graph.nodes.Count - 1);
            //    int to = rnd.Next(0, graph.nodes.Count - 1);

            //    while (to == from)
            //    {
            //        to = rnd.Next(0, graph.nodes.Count - 1);

            //    }
            //    graph.nodes["Node #" + from].MakeConnection(graph.nodes["Node #" + to], false);
            //}



            //DFS.FindPath(9);

            BFS.FindPath(9);
            Console.ReadKey();
            var tmp = graph;
        }

        private static void TestGraph()
        {

            for (int i = 0; i < 10; i++)
            {
                Node node = new Node(i);
                graph.AddNode("Node #" + i, node);

                bool firstItem = true;



                if (i != 0 && graph.nodes["Node #" + (i - 1)] != null)
                {
                    graph.nodes["Node #" + (i - 1)].MakeConnection(node, false);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int from = rnd.Next(0, graph.nodes.Count - 1);
                int to = rnd.Next(0, graph.nodes.Count - 1);

                while (to == from)
                {
                    to = rnd.Next(0, graph.nodes.Count - 1);

                }
                graph.nodes["Node #" + from].MakeConnection(graph.nodes["Node #" + to], true);
            }


            for (int i = 0; i < graph.nodes.Count - 1; i++)
            {
                foreach (Edge edge in graph.nodes["Node #" + i].edges)
                {
                    Console.WriteLine(edge);
                }
                Console.ReadLine();
            }
        }
    }
}
