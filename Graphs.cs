using System;

namespace GraphsExample
{
    public class Graph
    {

        //undirected graph as an adjacency matrix
        public static void AddEdge(int[,] graph, int u, int v)
        {
            if (u < 0 || v < 0 || u >= graph.GetLength(0) || v >= graph.GetLength(1))
            {
                throw new ArgumentOutOfRangeException("Vertex index out of bounds.");
            }
            graph[u, v] = 1;
            graph[v, u] = 1; // Since it's undirected
        }

        public static void DisplayGraph(int[,] graph)
        {
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    Console.Write(graph[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            int[,] graph = new int[5, 5]; // Create a 5x5 adjacency matrix

            // Adding edges
            AddEdge(graph, 0, 1);
            AddEdge(graph, 0, 4);
            AddEdge(graph, 1, 2);
            AddEdge(graph, 1, 3);
            AddEdge(graph, 1, 4);
            AddEdge(graph, 2, 3);
            AddEdge(graph, 3, 4);

            // Display the graph
            Console.WriteLine("Adjacency Matrix of the Graph:");
            DisplayGraph(graph);

        }
    }

}