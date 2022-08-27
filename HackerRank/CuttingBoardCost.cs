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

        public static int CalculateTotalCost(List<int> cost_y, List<int> cost_x)
        {
            var ylen = cost_y.Count;
            var xlen = cost_x.Count;

            var ysort = cost_y.OrderByDescending(x => x).ToList();
            var xsort = cost_x.OrderByDescending(x => x).ToList();

            var cuts = cost_y.Count + cost_x.Count;
            int countx = 1;
            int county = 1;
            int cost = 0;

            for (int i = 0; i<cuts; i++)
            {
                if (ysort.Count() ==0)
                {
                    cost += county* xsort[0];
                    countx += 1;
                    xsort.RemoveAt(0);
                }
                else if (xsort.Count==0)
                {
                   cost += countx*ysort[0];
                    county += 1;
                    ysort.RemoveAt(0);     
                }
                else
                {
                    if (ysort[0] > xsort[0])
                    {
                        cost += countx*ysort[0];
                        county += 1;
                        ysort.RemoveAt(0);
                    }
                    else if (ysort[0] < xsort[0])
                    {
                        cost += county*xsort[0];
                        countx += 1;
                        xsort.RemoveAt(0);
                    }
                    else
                    {
                        if (ylen-county >= xlen-countx)
                        {
                            cost += countx*ysort[0];
                            county += 1;
                            ysort.RemoveAt(0);
                        }
                        else
                        {
                            cost += county*xsort[0];
                            countx += 1;
                            xsort.RemoveAt(0);
                        }
                    }
                }
            }

            return cost % (int) (Math.Pow(10, 9) + 7);
        }


        public static int CalculateCostPython(List<int> cost_y, List<int> cost_x)
        {
            // cost_y ... 0 to m-2,  cost_x ... 0 to n-2
            int rows = cost_y.Count + 1;
            int cols = cost_x.Count +1;
            int hs=1;
            int vs=1;
            cost_x = cost_x.OrderByDescending(x=>x).ToList();
            cost_y = cost_y.OrderByDescending(x=>x).ToList();
            
            int sum = 0;
            while(cost_x.Any() && cost_y.Any())
            {
                int m = 0;
                int vsf;
                int hsf;
                if(cost_y[0]>cost_x[0])
                {
                    m=cost_y[0];
                    cost_y.RemoveAt(0);
                    vsf=1;
                    hsf=0;
                }
                else
                {
                    m=cost_x[0];
                    cost_x.RemoveAt(0);
                    vsf=0;
                    hsf=1;
                }
                    
                if(vsf == 1)
                {
                    sum+=(m*vs);
                    hs+=1;
                }
                    
                if(hsf == 1)
                {
                    sum+=(m*hs);
                    vs+=1;
                }
                    
                while(cost_x.Any())
                {
                    m=cost_x[0];
                    cost_x.RemoveAt(0);

                    sum+=(m*hs);
                    vs+=1;
                }
                while(cost_y.Any())
                {
                    m=cost_y[0];
                    cost_y.RemoveAt(0);

                    sum+=(m*vs);
                    hs+=1;
                }
            }
            
            return sum % 1000000007;
        }


        public static int minimumCostOfBreaking(List<int> X, List<int> Y)  
        {  
            int res = 0;  

            // sort the horizontal cost in reverse order  
            X = X.OrderByDescending(x => x).ToList(); 
            Y = Y.OrderByDescending(x => x).ToList(); 

            // initialize current width as 1  
            int hzntl = 1, vert = 1;  

            // loop until one or both  
            // cost array are processed  
            int i = 0, j = 0;  

            while (i < X.Count && j < Y.Count)  
            {  
                if (X[i] > Y[j])  
                {  
                    res += X[i] * vert;  

                    // increase current horizontal  
                    // part count by 1  
                    hzntl++;  
                    i++;  
                }  
                else
                {  
                    res += Y[j] * hzntl;  

                    // increase current vertical  
                    // part count by 1  
                    vert++;  
                    j++;  
                }  
            }  

            // loop for horizontal array,  
            // if remains  
            int total = 0;  
            while (i < X.Count)  
                total += X[i++];  

            res += total * vert;  

            // loop for vertical array,  
            // if remains  
            total = 0;  
            while (j < Y.Count)  
                total += Y[j++];  

            res += total * hzntl;  

            return res;  
        }
    }
}