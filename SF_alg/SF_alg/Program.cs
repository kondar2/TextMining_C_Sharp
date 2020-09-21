using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SF_alg
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;


            string[] allText = File.ReadAllLines(@"/Users/roman/Desktop/4 курс С#/все_сделанное/сделанное_с_тестами/text.txt", Encoding.Default);
            string[] allPattern = File.ReadAllLines(@"/Users/roman/Desktop/4 курс С#/все_сделанное/сделанное_с_тестами/pattern.txt", Encoding.Default);
            string[] allResult = File.ReadAllLines(@"/Users/roman/Desktop/4 курс С#/все_сделанное/сделанное_с_тестами/result.txt", Encoding.Default);

            for (int i = 0; i < allResult.Length; i++)
            {
                List<char> T = new List<char>();
                List<char> P = new List<char>();

                string text = allText[i];

                int numT = 0;

                foreach (char strT in text)
                {
                    T.Add(strT);
                    numT++;
                }

                string pattern = allPattern[i];

                int numP = 0;
                
                foreach (char strP in pattern)
                    {
                        P.Add(strP);
                        numP++;
                    }

                //string strResult = allResult[i];

                string[] Result = allResult[i].Split();


                for (int j = 0; j < Result.Length; j++)
                {
                    int countResult = Convert.ToInt32(Result[j]);


                    var res = SF.Fun(T, P, numT, numP);
                    
                    if (res.Count == 0)
                    {
                        Console.WriteLine("Нет вхождений");

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
