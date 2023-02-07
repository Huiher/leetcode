namespace HackerRank
{
    public class BinaryGap
    {
        public int Find(int valueToSearch)
        {
            // Convert the value into binary string
            var binaryString = Convert.ToString(valueToSearch, 2);

            return binaryString.Trim('0').Split('1').Max(x => x.Length);
        }
    }
}