using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mass_gran
{
    class PreficsFun
    {
        public static List<int> OccurrencesOfText(string text, string pattern)
        {
            var MatchIndexes = new List<int>();
            if (text.Length == 0 || pattern.Length == 0)
            {
                return MatchIndexes;
            }

            var list_pi = PrefixFunc(pattern + "#" + text);
            var res = new List<int>();
            for (int i = pattern.Length; i < list_pi.Count; i++)
            {
                if (list_pi[i] == pattern.Length)
                {
                    
                    res.Add(i - 2 * pattern.Length);
                }
            }

            return res;

        }


        public static List<int> PrefixFunc (string str)
        {
            var pi = new List<int>() { 0 };
            var j = pi[0];

            for (int i = 1; i < str.Length; i++)
            {
                pi.Add(0);
                while (j > 0 && str[j] != str[i])
                {
                    j = pi[j - 1];
                }
                if (str[i] == str[j])
                {
                    j++;
                }
                pi[i] = j;
            }

            return pi;

        }

    }
}
