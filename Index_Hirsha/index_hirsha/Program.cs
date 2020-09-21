using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace index_hirsha
{
    class Program : dic
    {
        static void Main(string[] args)
        {

            // Dictionary <int,int> stat = new Dictionary<int, int>();



            /*
            StreamReader sr = new StreamReader(@"C:\Users\konda\Desktop\4-Data_Min-2019\lab0(1)\2.txt");

            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] w = s.Split();
                foreach (string tmp in w)
                {
                    Console.Writeline
                }
            }
            */

            

            stat.Add(1, 20);
            stat.Add(2, 10);
            stat.Add(3, 10);
            stat.Add(4, 7);
            stat.Add(5, 6);
            stat.Add(6, 3);
            stat.Add(7, 1);

           


            /*int first = 0;
                int sec = 0;

                foreach (KeyValuePair<int, int> s in stat)
                {


                    while (s.Key < s.Value)
                    {
                        first = s.Key;
                        sec = s.Value;
                        break;
                    }
                }

                Console.WriteLine(first + " - " + sec + "\n");*/


            foreach (KeyValuePair<int,int> v in stat)
            {
                Console.WriteLine(v.Key + " - " +v.Value);
            }
                
               

            Console.ReadKey();
        }
    }
}
