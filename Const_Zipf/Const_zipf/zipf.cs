using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Const_zipf
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            SortedDictionary<int, int> numRanks = new SortedDictionary<int, int>();
            List<int> ranks = new List<int>();
            int numWords = 0;

            StreamReader sr = new StreamReader(@"C:\Users\konda\Desktop\4-Data_Min-2019\Новая папка\1.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] w = s.Split();
                foreach (string str in w)
                {
                    string tmp = str.Trim('\'', '"', '.', ',', ';', ':', '?', '!', '-', '_', '(', ')', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
                    tmp = tmp.ToLowerInvariant();
                    if (tmp != "")
                    {
                        numWords++;
                        if (words.ContainsKey(tmp))
                        {
                            words[tmp]++;
                        }
                        else
                        {
                            words.Add(tmp, 1);
                        }
                    }
                }
            }
            sr.Close();

            foreach (KeyValuePair<string,int> k in words)
            {
                if (!ranks.Contains(k.Value))
                {
                    ranks.Add(k.Value);
                }
                if (numRanks.ContainsKey(k.Value))
                {
                    numRanks[k.Value]++;
                }
                else
                {
                    numRanks.Add(k.Value, 1);
                }

            }
            ranks.Sort();
            ranks.Reverse();

            foreach (KeyValuePair<string,int> k in words)
            {
                Console.WriteLine(k.Key + " " + k.Value);
            }

            Console.WriteLine("________________________________");

            foreach (KeyValuePair<int, int> k in numRanks)
            {
                Console.WriteLine(k.Key + " " + k.Value);
            }

            Console.WriteLine("________________________________");

            foreach (var ka in ranks)
            {
                Console.WriteLine(ka);
            }

            Console.WriteLine("________________________________");
            Console.WriteLine(numWords);

            Console.WriteLine("________________________________");

            double ZipfC1 = 0;
            double ZipfC2 = 0;
            for (int i = 0; i < ranks.Count; i++)
            {
                ZipfC1 += ((ranks[i]) * (double)(i + 1) / numWords);
                Console.WriteLine(ZipfC1);
            }

            Console.WriteLine("________________________________");

            foreach (KeyValuePair<int,int> kvp in numRanks)
            {
                if(kvp.Key <= 100)
                {
                    ZipfC2 += kvp.Key * (double)kvp.Value / numWords;
                    Console.WriteLine(ZipfC2);
                }
            }
            Console.WriteLine("________________________________");

            Console.WriteLine(ranks.Count);
            Console.WriteLine(numRanks.Count);
            Console.WriteLine("________________________________");


            /*
            ZipfC1 /= ranks.Count;
            ZipfC2 /= numRanks.Count;
            Console.WriteLine(ZipfC1);
            Console.WriteLine(ZipfC2);
            */


            /*
            foreach (var s in ranks)
            {
                int _rus = ranks[(int)(0.6 * (double)ranks.Count)];
                Console.WriteLine(_rus);
            }
            

            Console.WriteLine("________________________________");
           */

            Console.ReadKey();
        }
    }
}
