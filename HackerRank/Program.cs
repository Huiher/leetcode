namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxLength("abcabcddd"));
        }

        public static int MaxLength(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            if (s.Length == 1)
            {
                return 1;
            }

            // Get single charachter occurrence and count
            IDictionary<char, int> charCountDict = new Dictionary<char, int>();
            for(int i=0; i<s.Length; i++)
            {
                var current = s[i];
                if (charCountDict.ContainsKey(current))
                {
                    charCountDict[current]++;
                }
                else
                {
                    charCountDict.Add(current, 1);
                }
            }

            var nonSingleDictionary = new Dictionary<string, int>();
            for(int i=0; i<s.Length-1; i++)
            {
                for(int j=i+1; j<s.Length; j++)
                {
                    var length = j-i+1;
                    var subString = s.Substring(i, length);

                    if (nonSingleDictionary.ContainsKey(subString))
                    {
                        nonSingleDictionary[subString] += length;
                    }
                    else
                    {
                        nonSingleDictionary.Add(subString, length);
                    }                    
                }
            }

            return Math.Max(charCountDict.Select(x => x.Value).Max(), nonSingleDictionary.Select(x =>x.Value).Max());
        }
    }
}