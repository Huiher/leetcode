using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    public class ArrayForDifference
    {
        public static int CheckCountForDiffernece(List<int> arr, int k)
        {
            if (arr.Count == 1)
            {
                return 0;
            }

            arr = arr.OrderBy(x => x).ToList();

            HashSet<int> values = new HashSet<int>(arr);

            int count = 0;
            foreach(var v in arr)
            {
                if (values.Contains(v + k))
                {
                    count++;
                    continue;
                }

                values.Remove(v);
            }

            return count;
        }
    }
}