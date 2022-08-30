using System.IO;
namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************");
            Console.WriteLine();
            Console.WriteLine("BFS vs. DFS");
            Console.WriteLine();
            Console.WriteLine("************************");

            Graph graph = new Graph(4);

            graph.AddEdge(0,1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1,2);
            graph.AddEdge(2,0);
            graph.AddEdge(2,3);
            graph.AddEdge(3,3);

            //Print adjacency matrix
            graph.PrintAdjacecnyMatrix();
 
            Console.WriteLine("BFS traversal starting from vertex 2:");
            graph.BFS(2);

            Console.WriteLine("DFS traversal starting from vertex 2:");
            graph.DFS(2);
        }
    }
}