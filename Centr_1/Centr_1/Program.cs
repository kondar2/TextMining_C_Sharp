using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Centr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<double> aaa = new List<double>();
            Dictionary<double, double> sss = new Dictionary<double, double>();
            SortedDictionary<double, double> sDic = new SortedDictionary<double, double>();

            int num = 0;
            double resStr;
            

            StreamReader sr = new StreamReader(@"C:\Users\konda\Desktop\4-Data_Min-2019\DZ\lab1\1.txt", Encoding.Default);

            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] w = s.Split();
                foreach  (string str in w)
                {
                    num++;
                    resStr = Convert.ToDouble(str);
                    aaa.Add(resStr);

                    Console.WriteLine(num);
                }
                

            }

            sr.Close();

            //////////////////////////////////////////////////////////////////////////////////////////

            StreamReader st = new StreamReader(@"C:\Users\konda\Desktop\4-Data_Min-2019\DZ\lab1\2.txt", Encoding.Default);

            int num2 = 0;

            while (!st.EndOfStream)
            {
                string s = st.ReadLine();
                string[] w = s.Split();
                
                    sss.Add(Convert.ToDouble(w[0]), Convert.ToDouble(w[1]));
                    num2++;
                    
            }
            
            st.Close();
            


            //zadd1.sred(aaa, num);
            //zadd1.sred2(aaa, num);
            //zadd1.sred_vzvesh(sss,num2);
            //zadd1.medi(aaa,num);
            zadd1.medi_vzvesh(sss, num2);

            //zad2.abs_otk(aaa, num);


            Console.ReadKey();


        }
    }
}
