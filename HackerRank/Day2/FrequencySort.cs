namespace HackerRank
{
    public static class FrequencySort
    {
        public static List<int> Sort(List<int> arr)
        {
            var frequencyArray = new int[100];
        
            foreach(var intValue in arr)
            {
                // Get the value
                frequencyArray[intValue]++;
            }
            
            return frequencyArray.ToList();
        }

    }
}