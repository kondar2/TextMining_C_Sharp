using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabin_Karp
{
    class Rab_Kar
    {
        public static int x = 2;

        public static List<int> OccurrencesOfText(string text, string pattern)
        {
            var MatchIndexes = new List<int>();
            if (text.Length == 0 || pattern.Length == 0)
            {
                return MatchIndexes;
            }

            int textHash = Hash(text.Substring(0, pattern.Length));
            int patternHash = Hash(pattern.Substring(0, pattern.Length));

            if (textHash == patternHash)
            {
                MatchIndexes.Add(0);
            }

            for (int i = 0; i < text.Length - pattern.Length; i++)
            {
                textHash = (textHash - (int)Math.Pow(x, pattern.Length - 1) * (text[i])) * x + 
                    (text[i + pattern.Length]);

                if (textHash == patternHash)
                {
                    MatchIndexes.Add(i + 1);
                }


            }
            return MatchIndexes;
            
        }

        private static int Hash(string s)
        {
            var sum = 0;
            var pow = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                sum += (s[i]) * (int)Math.Pow(x, pow);
                pow--;
            }
            return sum;
        }





    }
}
