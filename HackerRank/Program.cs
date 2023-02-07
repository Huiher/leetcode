using System.IO;
namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{1,2,3,4};
            var shifted = ShiftArray.Shift(array, 5);
            foreach(var i in shifted)
            {
                Console.Write($"{i},");
            }
        }

        public static void Sum(List<int> arr)
            {
                var sortedArray = arr.OrderBy(x => x).ToList();
                
                var smallest = sortedArray.Take(4).ToList();
                var biggest = sortedArray.TakeLast(4).ToList();

                long smallSum = 0;
                long bigSum = 0;
                for(int i=0; i<4; i++)
                {
                    smallSum += smallest[i];
                    bigSum += biggest[i];     
                }

                Console.WriteLine($"{smallSum} {bigSum}");
            }

        public static string timeConversion(string s)
        {
            // Get the AM/PM
            var ampm = s.Substring(s.Length-2, 2);
            var time = s.Substring(0, s.Length-2);
            
            // get the hour big
            var timeSegments = time.Split(':');
            if (timeSegments[0] == "12")
            {
                if (ampm == "AM")
                {
                    return string.Format("00:{0}:{1}", timeSegments[1], timeSegments[2]); 
                }
                else
                {
                    return string.Format("12:{0}:{1}", timeSegments[1], timeSegments[2]);
                }
            }
            else
            {
                
                var hour = int.Parse(timeSegments[0]);
                var hourIn24 = ampm == "PM" ? (hour + 12).ToString(): $"0{hour}";
                return string.Format("{0}:{1}:{2}", hourIn24, timeSegments[1], timeSegments[2]); 
            }
        }
    }
}