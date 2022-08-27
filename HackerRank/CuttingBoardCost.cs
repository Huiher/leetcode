using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    public class CuttingBoardCost
    {
        public enum CutDirection
        {
            Horizontal,
            Vertical
        }

        public static int BoardCutting(List<int> cost_y, List<int> cost_x)
        {
            int totalCost = 0;
           
            // Keep the row and col count
            var rowCount = cost_x.Count;
            var colCount = cost_y.Count;
            
            // sort the cost in desceding order 
            var costYDesc = cost_y.OrderByDescending(x => x).ToList();
            var costXDesc = cost_x.OrderByDescending(x => x).ToList();

            // recalculate the size, find the next most cost-effective way of cutting
            int rowCutCount = 0;
            int colCutCount = 0;

            int iteration = 1;

            while(costXDesc.Any() || costYDesc.Any())
            {
                Console.WriteLine($"**********Iteration {iteration++} started**********");

                // Get the possible segment that this cut gonna involve
                int encountersV = cost_y.Count == costYDesc.Count ? 1 : cost_y.Count - costYDesc.Count + 1;
                int encountersH = cost_x.Count == costXDesc.Count ? 1 : cost_x.Count - costXDesc.Count + 1;

                Console.WriteLine($"Vertical segmentss: {encountersV}, horizontal segments: {encountersH}");

                // calculate the cost horizontally and vertically
                var cutCostV = costXDesc.Any() ? costXDesc[0] * encountersV : 0;
                var cutCostH = costYDesc.Any() ? costYDesc[0] * encountersH : 0;

                Console.WriteLine($"Vertical cut cost: {cutCostV}, horizontal cut cost: {cutCostH}");

                // always take the cut of the highest cost first
                bool isHorizontalCut = cutCostH > cutCostV;

                string cutDirection= isHorizontalCut ? "Horizontal" : "Vertical";

                Console.WriteLine($"Take the {cutDirection} cut");

                switch (isHorizontalCut)
                {
                    case true:
                        costYDesc.RemoveAt(0);
                        rowCutCount++;
                        
                        totalCost += cutCostH;
                        break;

                    case false:
                        costXDesc.RemoveAt(0);
                        colCutCount++;
                        
                        // Add the cost
                        totalCost += cutCostV;
                        break;
                }

                Console.WriteLine($"cols left: {costYDesc.Count}, rows left: {costXDesc.Count}");
                Console.WriteLine();
                Console.WriteLine();
            }

            return totalCost % (int) (Math.Pow(10, 9) + 7);
        }
    }
}