using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Mass_block
{
    class Program
    {
        static void Main(string[] args)
        {


            //StreamReader textReader = new StreamReader(@"C:\Users\konda\Desktop\4-Data_Min-2019\DZ\lab1\text.txt", Encoding.Default);

            //List<string[]> allText = new List<string[]>();
            string[] allText = File.ReadAllLines(@"/Users/roman/Desktop/4 курс С#/все_сделанное/сделанное_с_тестами/text.txt", Encoding.Default);
            string[] allPattern = File.ReadAllLines(@"/Users/roman/Desktop/4 курс С#/все_сделанное/сделанное_с_тестами/pattern.txt", Encoding.Default);
            string[] allResult = File.ReadAllLines(@"/Users/roman/Desktop/4 курс С#/все_сделанное/сделанное_с_тестами/result.txt", Encoding.Default);

            for (int i = 0; i < allResult.Length; i++)
            {
                string text = allText[i];

                string pattern = allPattern[i];

                string strResult = allResult[i];
                string[] Result = strResult.Split();


                for (int j = 0; j < Result.Length; j++)
                {
                    int countResult = Convert.ToInt32(Result[j]);

                    var res = BlockFun.OccurrencesOfText(text, pattern);
                    if (res.Count == 0)
                    {
                        Console.WriteLine("no occurrences");

                    }
                    else
                    {
                        if (res[j] == countResult)
                        {
                            Console.WriteLine("true");
                        }
                        else
                        {
                            Console.WriteLine("false");
                        }
                    }
                }
            }

            Console.ReadKey();



        }
    }
}
