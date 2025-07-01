using System;

namespace GraphsExample
{
    public class Graph
    {
        // undirected graph represented as an adjacency list

        public static void AddEdgeList(List<List<int>> adj, int i, int j)
        {
            adj[i].Add(j);
            adj[j].Add(i); // Since it's undirected
        }

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

        public static void DisplayAdjacencyList(List<List<int>> adj)
        {
            for (int i = 0; i < adj.Count; i++)
            {
                Console.Write(i + ": ");
                foreach (var vertex in adj[i])
                {
                    Console.Write(vertex + " ");
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

            // Create an adjacency list
            List<List<int>> adjList = new List<List<int>>();
            for (int i = 0; i < 5; i++)
            {
                adjList.Add(new List<int>());
            }
            // Adding edges to the adjacency list
            AddEdgeList(adjList, 0, 1);
            AddEdgeList(adjList, 0, 4);
            AddEdgeList(adjList, 1, 2);
            AddEdgeList(adjList, 1, 3);
            AddEdgeList(adjList, 1, 4);
            AddEdgeList(adjList, 2, 3);

            // showing the adjacency list
            Console.WriteLine("Adjacency List of the Graph:");
            DisplayAdjacencyList(adjList);

        }
    }

}