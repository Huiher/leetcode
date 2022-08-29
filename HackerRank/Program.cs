using System.IO;
namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Substring.MaxLength("abcabcddd"));
            // var filePath = @"D:\Git\leetcode\HackerRank\s1.txt";
            // Console.WriteLine(Substring.MaxLength(FileReaderHelper.ReadFileAsText(filePath)));

            // var orderList = new List<List<int>>{
            //     new List<int>{5},
            //     new List<int>{8,1},
            //     new List<int>{4,2},
            //     new List<int>{5,6},
            //     new List<int>{3,1},
            //     new List<int>{4,3},
            // };

            // var deliveryList = JimOrder.JimOrders(orderList);
            // Console.WriteLine(string.Join(' ', deliveryList));

            // var aList = new List<int>{1, 2, 2, 1};
            // var bList = new List<int>{3, 3, 3, 4};

            // var result = PermuteTwoArrays.Permute(5, aList, bList);
            // Console.WriteLine(string.Join(' ', aList));
            // Console.WriteLine(result);

            Console.WriteLine("************************");
            Console.WriteLine();
            Console.WriteLine("Queue time calculation");
            Console.WriteLine();
            Console.WriteLine("************************");

            // var costY = new List<int>{2,1,3,1,4};
            // var costX = new List<int>{4,1,2};

            // var costY = new List<int>{7, 69, 87, 54, 1, 27, 92, 58, 24, 86, 16, 18, 14, 68, 65, 24, 37, 66, 78, 14, 27, 72, 23, 65, 9, 43, 45, 3, 7, 59, 33, 66, 28, 20, 20, 29, 99, 12, 39, 23, 51, 55, 94, 17, 23, 11, 93, 60, 77, 72, 26, 57, 96, 2, 22, 58, 45, 68, 61, 4, 27, 47};
            // var costX = new List<int>{70, 7, 19, 42, 36, 19, 7, 27, 94, 58, 82, 40, 27, 57, 51, 21, 69, 81, 93, 96, 38, 41, 50, 60, 99, 47, 28, 61, 52, 7, 60};

            // var totalCost = CuttingBoardCost.minimumCostOfBreaking(costY, costX);
            // Console.WriteLine($"Total cost is {totalCost}");

            // var timeTaken = BuyShowTicket.CalculateQueueTime(new List<int>{5, 5, 2, 3}, 3);
            // Console.WriteLine($"Time taken to get the ticket: {timeTaken}");

            var ranked = new List<int>{ 100 ,90, 90, 80, 75, 60};
            var players = new List<int>{ 50, 65, 77, 90, 102};

            var result = DenseRanking.CalculateLeaderBoard(ranked, players);
            Console.WriteLine(string.Join(",", result));
        }
    }
}