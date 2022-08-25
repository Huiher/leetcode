using System;
using Newtonsoft.Json;
using System.Threading;

namespace VSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = TwoSum(new int[]{1,2,3}, 4);

            if (result.Length > 0)
            {
                Console.WriteLine(result[0]);
                Console.WriteLine(result[1]);
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for(int i=0; i<nums.Length-1; i++)
            {
                for(int j=1+i; j<nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2]{i, j};
                    }
                }
            }

            return new int[0];
        }

        private static void Foo()
        {
            Console.WriteLine("hello world");
        }
    }
}