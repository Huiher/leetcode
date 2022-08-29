using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    public class DenseRanking
    {
        public static List<int> CalculateLeaderBoard(List<int> ranked, List<int> player)
        {
            // Get the distinct list including all the players
            var rankedDistinct = ranked.Distinct().ToList();

            var playerRanking = new List<int>();
            
            foreach (var score in player)
            {
                int currrentRanking;
                if (rankedDistinct.Contains(score))
                {
                    currrentRanking = rankedDistinct.IndexOf(score) + 1;
                }
                else
                {
                    var currentDenseRanking = new List<int>(rankedDistinct);
                    currentDenseRanking.Add(score);

                    var orderedLeagueTable = currentDenseRanking.OrderByDescending(x => x).ToList();
                    currrentRanking = orderedLeagueTable.IndexOf(score) + 1;
                    
                }

                playerRanking.Add(currrentRanking);
            }
            
            return playerRanking;
        }
    }
}