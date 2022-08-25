using System.IO;
namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"D:\Git\leetcode\HackerRank\s2.txt";

            // Console.WriteLine(Substring.MaxLength("abcabcddd"));
            Console.WriteLine(Substring.MaxLength(ReadFileAsText(filePath)));
        }

        static string ReadFileAsText(string path)
        {
            return File.ReadAllText(path);
        }
    }
}