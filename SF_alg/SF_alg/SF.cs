using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_alg
{
    class SF
    {
        public static List<int> Fun(List<char> T, List<char> P, int numT, int numP)
        {

            var sovp = new List<int>();

            for (int i = 0; i <= (numT - numP); i++)
                {
                    int j = 0;
                
                Encoding utf8 = Encoding.UTF8;
                Encoding unicode = Encoding.Unicode;
                while ((j < numP) && ((Convert.ToByte(P[j])) == Convert.ToByte(T[i + j])))
                    {
                        j++;

                        if (j == numP)
                        {
                        sovp.Add(i);
                        }   
                    }
                }
            return sovp;

                /*
            if (sovp.Count != 0)
            {
                foreach  (int sovvp in sovp)
                {
                    Console.WriteLine("Совпадение начиная с индекса : " + sovvp);
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            */

            /*
             string unicodeString = "0e2a0e270e310e2a0e140e350e040e230e310e1a";
            // Create two different encodings.
            Encoding utf8 = Encoding.UTF8;
            Encoding unicode = Encoding.Unicode;

            // Convert the string into a byte[].
            byte[] unicodeBytes = unicode.GetBytes(unicodeString);

            // Perform the conversion from one encoding to the other.
            byte[] utf8Bytes = Encoding.Convert(unicode, utf8, unicodeBytes);

            // Convert the new byte[] into a char[] and then into a string.
            // This is a slightly different approach to converting to illustrate
            // the use of GetCharCount/GetChars.

            char[] asciiChars = new char[utf8.GetCharCount(utf8Bytes, 0, utf8Bytes.Length)];
            utf8.GetChars(utf8Bytes, 0, utf8Bytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);

            return asciiString;
             */
        }

    }
}
