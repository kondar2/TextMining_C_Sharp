using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Boyer_Moore_code
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            /*
            string[] allText = File.ReadAllLines(@"/Users/roman/Desktop/4 курс С#/DATA_MIN/все_сделанное/Boyer_Moore_code/Boyer_Moore_code/bin/Debug/text.txt", Encoding.Default);
            string[] allPattern = File.ReadAllLines(@"/Users/roman/Desktop/4 курс С#/DATA_MIN/все_сделанное/Boyer_Moore_code/Boyer_Moore_code/bin/Debug/pattern.txt", Encoding.Default);
            string[] allResult = File.ReadAllLines(@"/Users/roman/Desktop/4 курс С#/DATA_MIN/все_сделанное/Boyer_Moore_code/Boyer_Moore_code/bin/Debug/result.txt", Encoding.Default);

            for (int i = 0; i < allResult.Length; i++)
            {
                string text = allText[i];

                string pattern = allPattern[i];

                string strResult = allResult[i];
                string[] Result = strResult.Split();


                for (int j = 0; j < Result.Length; j++)
                {
                    int countResult = Convert.ToInt32(Result[j]);

                    var res = Contains.ContainsPattern(text, pattern);

                    //Console.WriteLine(res[j]);

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
            */


            
             Console.WriteLine("Введите текст: ");
            var text = Console.ReadLine();
            Console.WriteLine("Введите паттерн: ");
            var pattern = Console.ReadLine();

            var res = Contains.ContainsPattern(text, pattern);
            if (res.Count == 0)
            {
                Console.WriteLine("Нет вхождений");
            }
            else
            {
                foreach (var item in res)
                {
                    Console.WriteLine("Вхождение по индексу: " + item);
                }
            }
             

            Console.ReadKey();




        }
    }
}
