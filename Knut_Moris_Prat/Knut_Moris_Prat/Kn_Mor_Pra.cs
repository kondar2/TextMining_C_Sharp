using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knut_Moris_Prat
{
    class Kn_Mor_Pra
    {
        
        public static List<int> FindSubstring(string text, string pattern)
        {
            var indexOfMatches = new List<int>();
            
            //int res = -1;
            int[] pf = GetPrefix(pattern);
            int index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (index > 0 && pattern[index] != text[i])
                {
                    //i += index;
                    //i += (index - pf[index]) - 1;
                    
                    i += (index - pf[index]);
                    /*
                    while (i >= (text.Length - pattern.Length))
                    {
                        i--;
                    }
                    */
                }

                while (index > 0 && pattern[index] != text[i])
                {
                    
                    index = pf[index - 1];

                   // i = i + (index - pf[index]);
                }

                if (pattern[index] == text[i])
                    index++;

                /*if (index != pattern.Length && index > 0)
                {
                    i = i + (index - pf[index]);
                }*/

                if (index == pattern.Length)
                {
                    indexOfMatches.Add(i - index + 1);
                    index--;
                }
            }

            return indexOfMatches;
        }


        static int[] GetPrefix(string s)
        {
            int[] result = new int[s.Length];
            result[0] = 0;
            int index = 0;

            for (int i = 1; i < s.Length; i++)
            {
                while (index >= 0 && s[index] != s[i])
                {
                    index--;
                }

                index++;
                result[i] = index;
            }

            return result;
        }

    }
}
