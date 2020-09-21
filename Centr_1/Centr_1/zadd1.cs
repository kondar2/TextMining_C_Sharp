using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centr_1
{
    class zadd1
    {
        public static void sred (List<double> aaa, int num)
        {

            double resInt = 0;
            double res = 0;

            foreach (int chis in aaa)
            {
                
                resInt += chis;
                Console.WriteLine(resInt);
            }

            res = resInt / num;
            Console.WriteLine("Среднее арифметическое : " + res);

        }

        public static void sred2(List<double> aaa, int num)
        {
            
            
            aaa.Sort();
            aaa.Remove(aaa.First());
            //aaa.Reverse();
            aaa.Remove(aaa.Last());
            

            double resInt = 0;
            double res = 0;

            foreach (int chis in aaa)
            {

                resInt += chis;
                Console.WriteLine(resInt);
            }

            res = resInt / num;
            Console.WriteLine("Среднее усеченное : " + res);

        }

        public static void sred_vzvesh(Dictionary<double,double> sss, int num2)
        {
            
            double resProd = 0;
            double resSumm = 0;
            double res = 0;

            foreach (KeyValuePair<double,double> chi in sss)
            {

                resProd += chi.Key * chi.Value;
                Console.WriteLine(resProd);
            }

            foreach (KeyValuePair<double, double> che in sss)
            {
                resSumm += che.Value;
                Console.WriteLine(resSumm);
            }

            res = resProd / resSumm;
            Console.WriteLine("Среднее взвешанное : " + res);

        }

        public static void medi(List<double> aaa, int num)
        {
            
            

            aaa.Sort();
            
            if (num%2 == 0)
            {
                int pos1 = num/2;
                int pos2 = pos1++;

                double res = Convert.ToDouble(aaa[pos1] + aaa[pos2]) / 2;

                Console.WriteLine("Медиана : " + res);

            }
            else
            {
                int pos = num / 2;
                
                Console.WriteLine("Медиана : " + aaa[pos]);
            }     
       
            
        }

        public static void medi_vzvesh(Dictionary<double, double> sss, int num2)
        {
          
            //сортировка словаря
            
            var sDic = new SortedDictionary<double, double>(sss);
            foreach (var kvp in sDic)
            {
                Console.WriteLine("Key: " + kvp.Key + "; Value: " + kvp.Value);
            }
            
            //посчитать сумму вероятностей первой половины и второй


            /*
            if (num % 2 == 0)
            {
                int pos1 = num / 2;
                int pos2 = pos1++;

                double res = Convert.ToDouble(aaa[pos1] + aaa[pos2]) / 2;

                Console.WriteLine("Медиана : " + res);

            }
            else
            {
                int pos = num / 2;

                Console.WriteLine("Медиана : " + aaa[pos]);
            }
            */

        }

    }
}
