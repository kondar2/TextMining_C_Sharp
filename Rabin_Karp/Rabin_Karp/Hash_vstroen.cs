using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Rabin_Karp
{
    class Hash_vstroen
    {
        public static List<int> OccurrencesOfText(string text, string pattern)
        {
            var MatchIndexes = new List<int>();
            if (text.Length == 0 || pattern.Length == 0 || pattern.Length > text.Length)
            {
                return MatchIndexes;
            }

            

            byte[] textHash = HashFun(text.Substring(0, pattern.Length));
            byte[] patternHash = HashFun(pattern.Substring(0, pattern.Length));

            bool bEqual0 = false;
            if (textHash.Length == patternHash.Length)
            {

                int j = 0;
                while ((j < textHash.Length) && (textHash[j] == patternHash[j]))
                {
                    j += 1;
                }
                if (j == textHash.Length)
                {
                    bEqual0 = true;
                }
            }
            if (bEqual0)
                MatchIndexes.Add(0);




            for (int i = 0; i < text.Length - pattern.Length; i++)
            {
                textHash = HashFun(text.Substring(i+1, pattern.Length));


                bool bEqual = false;

                if (textHash.Length == patternHash.Length)
                {
                    int j = 0;
                    while ((j < textHash.Length) && (textHash[j] == patternHash[j]))
                    {
                        j += 1;
                    }
                    
                       bEqual = j == textHash.Length;
                    
                }

                if (bEqual)
                    MatchIndexes.Add(i+1);


            }
            return MatchIndexes;
            

        }



        private static byte[] HashFun(string s)
        {
            string sSourseData = s;
            byte[] tmpSource; //в байтах
            byte[] tmpHash;  //хэш

            
            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourseData); //последовательность байтов
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            //вычисленное значение хэша 128-разрядный хэш = 16 байт

            return tmpHash;
        }




    }
}
