using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boyer_Moore_code
{
    class Contains
    {
        public static List<int> ContainsPattern(string text, string pattern)
        {

            var indexesOfMatches = new List<int>();
            if (pattern.Length == 0 || text.Length == 0 || pattern.Length > text.Length)
            {
                return indexesOfMatches;
            }

            var dTable = DTable(pattern);
            var matchingSuffixesTable = MatchingSuffixesTable(pattern);
            var k = 0;
            var j = 0;
            var elementsToSkip = 0;

            for (int i = pattern.Length - 1; i < text.Length; i++)
            {
                k = pattern.Length - 1;
                j = i;
                while (k >= 0 && text[j] == pattern[k])
                {
                    k--;
                    j--;
                }
                if (k<0)
                {
                    indexesOfMatches.Add(i - pattern.Length + 1);
                    continue;
                }

                elementsToSkip = pattern.Length;
                foreach (var item in dTable)
                {
                    if (item.Key == text[i])
                    {
                        elementsToSkip = item.Value;
                        break;
                    }
                }

                elementsToSkip = Math.Max(elementsToSkip - k, 1);

                if (i - j > 0)
                {
                    elementsToSkip = Math.Max(elementsToSkip, matchingSuffixesTable[i - j]);
                }

                i += elementsToSkip - 1;
                
            }
            return indexesOfMatches;
        }

        


        private static List<int> MatchingSuffixesTable(string s)
        {
            var sufShift = new List<int>();
            var pi = PrefixFunction(s);
            pi[0] = 0;
            var pi1 = PrefixFunction(new string(s.Reverse().ToArray()));
            pi1[0] = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sufShift.Add(s.Length - pi[s.Length - 1]);
            }

            var j = 0;
            for (int i = 1; i < s.Length; i++)
            {
                j = s.Length - 1 - pi1[i];
                sufShift[j] = Math.Min(sufShift[j], i - pi1[i - 1]);
            }
            sufShift.Reverse();

            return sufShift;
        }


        private static Dictionary<char, int> DTable(string s)
        {
            var dTable = new Dictionary<char, int>();
            dTable.Add(s[s.Length - 1], s.Length);

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (dTable.ContainsKey(s[i]))
                {
                    dTable[s[i]] = s.Length - i - 1;
                    continue;
                }
                dTable.Add(s[i], s.Length - i - 1);
            }


            return dTable;
        }

        private static List<int> PrefixFunction(string s)
        {
            var pi = new List<int>() { 0 };
            var j = pi[0];

            for (int i = 1; i < s.Length; i++)
            {
                pi.Add(0);
                while (j > 0 && s[j] != s[i])
                {
                    j = pi[j - 1];
                }
                if (s[i] == s[j])
                {
                    j++;
                }
                pi[i] = j;
            }
            return pi;
        }


    }
}
