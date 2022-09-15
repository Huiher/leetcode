using System.IO;
namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("************************");
            // Console.WriteLine();
            // Console.WriteLine("BFS vs. DFS");
            // Console.WriteLine();
            // Console.WriteLine("************************");

            // Graph graph = new Graph(4);

            // graph.AddEdge(0,1);
            // graph.AddEdge(0, 2);
            // graph.AddEdge(1,2);
            // graph.AddEdge(2,0);
            // graph.AddEdge(2,3);
            // graph.AddEdge(3,3);

            // //Print adjacency matrix
            // graph.PrintAdjacecnyMatrix();
 
            // Console.WriteLine("BFS traversal starting from vertex 2:");
            // graph.BFS(2);

            // Console.WriteLine("DFS traversal starting from vertex 2:");
            // graph.DFS(2);

            // Sum(new List<int>{256741038, 623958417, 467905213, 714532089, 938071625});
            Console.WriteLine(timeConversion("04:59:59AM"));
        }

        public static void Sum(List<int> arr)
            {
                var sortedArray = arr.OrderBy(x => x).ToList();
                
                var smallest = sortedArray.Take(4).ToList();
                var biggest = sortedArray.TakeLast(4).ToList();

                long smallSum = 0;
                long bigSum = 0;
                for(int i=0; i<4; i++)
                {
                    smallSum += smallest[i];
                    bigSum += biggest[i];     
                }

                Console.WriteLine($"{smallSum} {bigSum}");
            }

        public static string timeConversion(string s)
        {
            // Get the AM/PM
            var ampm = s.Substring(s.Length-2, 2);
            var time = s.Substring(0, s.Length-2);
            
            // get the hour big
            var timeSegments = time.Split(':');
            if (timeSegments[0] == "12")
            {
                if (ampm == "AM")
                {
                    return string.Format("00:{0}:{1}", timeSegments[1], timeSegments[2]); 
                }
                else
                {
                    return string.Format("12:{0}:{1}", timeSegments[1], timeSegments[2]);
                }
            }
            else
            {
                
                var hour = int.Parse(timeSegments[0]);
                var hourIn24 = ampm == "PM" ? (hour + 12).ToString(): $"0{hour}";
                return string.Format("{0}:{1}:{2}", hourIn24, timeSegments[1], timeSegments[2]); 
            }
            
        }
    }
}