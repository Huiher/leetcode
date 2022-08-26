using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    public class JimOrder
    {
        /*
        * Complete the 'jimOrders' function below.
        *
        * The function is expected to return an INTEGER_ARRAY.
        * The function accepts 2D_INTEGER_ARRAY orders as parameter.
        */

        public static List<int> JimOrders(List<List<int>> orders)
        {
            // Invalid input
            if (orders == null || orders.Count == 1)
            {
                return new List<int>();
            }

            // parameter error - return empty list
            if (orders[0][0] != orders.Count -1)
            {
                return new List<int>();
            }

            // Get rid of the first element which is just the count
            var ordersOnly = orders.Except(new List<List<int>>(){orders[0]}).ToList();

            var orderDeliveryTimeDictionary = ordersOnly.ToDictionary(x => orders.IndexOf(x), x => x[0] + x[1])
                .OrderBy(x => x.Value).ThenBy(x => x.Key);

            return orderDeliveryTimeDictionary.Select(x => x.Key).ToList();
        }
    }
}