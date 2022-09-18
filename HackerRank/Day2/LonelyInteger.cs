using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    public class LonelyInteger
    {
        public static int lonelyinteger(List<int> a)
        {
            // If only 1 element, return the only element
            if (a.Count == 1)
            {
                return a[0];
            }
            
            var dictionary = new Dictionary<int, int>();
            foreach(var element in a)
            {
                if (dictionary.ContainsKey(element))
                {
                    dictionary[element] = dictionary[element] + 1;
                }
                else
                {
                    dictionary.Add(element, 1);
                }
            }
            
            return dictionary.First(x => x.Value == 1).Key;
        }
    }
}