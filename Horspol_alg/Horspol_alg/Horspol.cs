using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horspol_alg
{
    class Horspol
    {

        public static List<int> OccurrencesOfText(string text, string pattern)
        {
            var MatchIndexes = new List<int>();
            if (text.Length == 0 || pattern.Length == 0 || pattern.Length > text.Length)
            {
                return MatchIndexes;
            }

            var dTable = DTable(pattern);
            var k = 0;
            var j = 0;
            var numSkip = 0;
            

            for (int i = pattern.Length - 1; i < text.Length; i++)
            {
                k = pattern.Length - 1; // last el pattern
                j = i; // last el text in compare

                while (k >= 0 && text[j] == pattern[k])
                {
                    k--;
                    j--;
                }
                if (k < 0)
                {
                    MatchIndexes.Add(i - pattern.Length + 1);
                    //continue;
                }

                numSkip = pattern.Length; 



                foreach (var item in dTable)
                {
                    if (item.Key == text[i]) 
                    {
                        numSkip = item.Value;
                        break;
                    }
                }

                i += numSkip - 1;
            }
            
            
            return MatchIndexes;

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

    }
}
