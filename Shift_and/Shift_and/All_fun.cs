using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shift_and
{
    class All_fun
    {

        public static List<int> OccurrencesOfText(string text, string pattern) {

            var indexOfMatches = new List<int>();
            if (pattern.Length == 0 || text.Length == 0)
            {
                return indexOfMatches;
            }

            var IntermidiateArray = MakeIntermidiateArray(text, pattern);
            var m = new List<int[]>();
            int[] partM;

            for (int i = 1; i <= text.Length; i++)
            {
                partM = new int[pattern.Length];
                var shift = BitShift(IntermidiateArray[i - 1]);
                var U_pattern = MakeU_pattern(pattern, text[i - 1]);

                for (int j = 0; j < shift.Length; j++)
                {
                    partM[j] = shift[j] & U_pattern[j];
                }
                m.Add(partM);
            }

            for (int i = 0; i < text.Length; i++)
            {
                //поиск 1 по индексу последнего элемента M[text], если 
                if (m[i][pattern.Length - 1] == 1)
                {
                    indexOfMatches.Add(i - pattern.Length + 1);
                }
         
            }
            return indexOfMatches;

        }

            private static int[] BitShift(int[] auxArray)
            {
                var shifted = auxArray.ToList();
                shifted.Insert(0, 1);
                shifted.RemoveAt(auxArray.Length);

                return shifted.ToArray();

            }

            static int[] MakeU_pattern(string text, char symbol)
            {
                var u = new int[text.Length];

                for (int j = 0; j < text.Length; j++)
                {
                    if (symbol == text[j])
                    
                        u[j] = 1;
                    
                }

                return u;
            }

            static List<int[]> MakeIntermidiateArray(string text, string pattern)
            {
                var m = new List<int[]>();
                for (int i = 0; i <= text.Length; i++)
                {
                    m.Add(new int[pattern.Length]);
                }

                for (int i = 0; i < pattern.Length; i++)
                {
                    for (int j = 0; j < text.Length - i; j++)
                    {
                        if (pattern.Substring(0, i + 1) == text.Substring(j, i + 1))
                        {
                            m[j + i + 1][i] = 1;
                            // 1 во все совпадающие позиции до конца текста
                        }

                    }

                }
                return m;

            }

        
    }
}
