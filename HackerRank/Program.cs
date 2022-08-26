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

            var aList = new List<int>{1, 2, 2, 1};
            var bList = new List<int>{3, 3, 3, 4};

            var result = PermuteTwoArrays.Permute(5, aList, bList);
            Console.WriteLine(string.Join(' ', aList));
            Console.WriteLine(result);
        }
    }
}