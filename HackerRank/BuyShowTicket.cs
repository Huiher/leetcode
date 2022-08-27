using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    public class BuyShowTicket
    {
        public static int CalculateQueueTime(List<int> queue, int position)
        {
            // If Alex is the only one in the queue, time taken is just the number of tickes he needs
            if (queue.Count == 1)
            {
                return queue[0];
            }

            // If only need 1 ticket
            if (queue[position] == 1)
            {
                return position + 1;
            }

            int timeTaken = 0;
            var firstTicketTime = position + 1;

            bool allTicketBought = false;
            int currentPosition = position;
            while (!allTicketBought)
            {
                // Process the first customer in the list, move to the end if more than 1 ticket
                var queueHeadRemainingTicketCount = queue[0] - 1;
                if (queueHeadRemainingTicketCount != 0)    
                {
                    queue.Add(queueHeadRemainingTicketCount);
                }
                queue.RemoveAt(0);

                timeTaken++;

                // If current position is 0 and no ticket remaining, all done
                if (currentPosition == 0 && queueHeadRemainingTicketCount == 0)
                {
                    allTicketBought = true;
                }
                else
                {
                    // otherwise current position is at the queue end
                    currentPosition = currentPosition == 0 ? queue.Count - 1 : currentPosition - 1;
                }

                var currentQueue = string.Join(',', queue);
                Console.WriteLine($"Current Queue: {currentQueue}");
            }

            return timeTaken;
        }   
    }
}