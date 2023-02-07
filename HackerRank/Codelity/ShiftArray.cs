namespace HackerRank
{
    public class ShiftArray
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
    }
}