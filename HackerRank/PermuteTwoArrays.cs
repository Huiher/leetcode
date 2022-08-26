using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    public class PermuteTwoArrays
    {
        public static string Permute(int k, List<int> A, List<int> B)
        {
            // Deal with 1-element situation
            if (A.Count == 1)
            {
                return A[0] + B[0] >= k ? "YES" : "NO";
            }

            if (A.Max() + B.Max() < k)
            {
                return "NO";
            }

            var size = A.Count();
            var sortedA = A.OrderByDescending(x => x).ToList();
            var sortedB = B.OrderBy(x => x).ToList();

            for (int i=0; i<size; i++)
            {
                if (sortedA[i] + sortedB[i] < k)
                {
                    return "NO";
                }    
            }

            return "YES";
        }
    }
}