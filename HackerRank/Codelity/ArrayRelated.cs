namespace HackerRank
{
    public class ArrayRelated
    {
        public static int[] Shift(int[] array, int k)
        {
            // Null check
            if (array == null)
            {
                return array;
            }

            // Get the effective rotation count
            var length = array.Length;
            int effectiveRotationCount = k % length;

            // If array is empty or 
            if (length <= 1 || k % length == 0)
            {
                return array;
            }

            int[] final = new int[length];
            for(int i=0; i<length; i++)
            {
                // calculate the new position
                var newIndex = (i+effectiveRotationCount) % length;
                final[newIndex] = array[i];
            }

            return final;
        }

        public static int FindUnpairedElement(int[] elements)
        {
            if (elements.Length == 1)
            {
                return elements[0];
            }

            var dict = new Dictionary<int, int>();
            foreach(var i in elements)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i] = dict[i]+1;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }
            
            return dict.FirstOrDefault(x => x.Value == 1).Key;
        }
    }
}