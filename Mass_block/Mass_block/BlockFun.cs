using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mass_block
{
    class BlockFun
    {
        public static List<int> OccurrencesOfText(string text, string pattern)
        {
            var str = pattern + "$" + text;
            var bl = GetBlock(str);
            var MatchIndexes = new List<int>();
            if (text.Length == 0 || pattern.Length == 0)
            {
                return MatchIndexes;
            }
            
            var res = new List<int>();
            for (int i = pattern.Length; i < bl.Length; i++)
            {
                if (bl[i] == pattern.Length)
                {

                    res.Add(i - pattern.Length - 1);
                }
            }

            return res;

        }

        private static int[] GetBlock(string str)
        {
            var blocks = new int[str.Length];
            blocks[0] = 0;
            var j = 0;
            for (int i = 1; i < str.Length; i++)
            {
                j = i;

                while (j < str.Length && str[j] == str[j - i])
                {
                    j++;
                }
                blocks[i] = j - i;
                
            }
            return blocks;

        }

    }
}
