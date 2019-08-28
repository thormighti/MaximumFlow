using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(6);
            //graph.AddEdge(0,1,10);
            //graph.AddEdge(0,2,8);
            //graph.AddEdge(1,2,5);
            //graph.AddEdge(1,3,5);
            //graph.AddEdge(2,1,4);
            //graph.AddEdge(2,4,10);
            //graph.AddEdge(3,2,7);
            //graph.AddEdge(3,4,6);
            //graph.AddEdge(3,5,3);
            //graph.AddEdge(4,3,10);
            //graph.AddEdge(4,5,14);
            graph.AddEdge(0,1,2);
            graph.AddEdge(0,2,8);
            graph.AddEdge(0,3,3);
            graph.AddEdge(1,2,7);
            graph.AddEdge(2,3,2);
            graph.AddEdge(1,4,2);
            graph.AddEdge(3,4,5);

            int maxFlow = graph.FindMaximumFlow(0, 4);
            Console.WriteLine(maxFlow);
            Console.ReadKey();
        }
    }
}
