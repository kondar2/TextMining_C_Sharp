using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centr_1
{
    class zad2
    {
        public static void abs_otk(List<int> aaa, int num)
        {

            int resInt = 0;
            double sr1 = 0;
            double sum_sr = 0;

            foreach (int chis in aaa)
            {

                resInt += chis;
                Console.WriteLine(resInt);
            }

            sr1 = Convert.ToDouble(resInt / num);

            double sr3 = 0;

            foreach (int ch in aaa)
            {
                
                double sr2 = ch - sr1;
                 sr3+=sr2;
            }

            Console.WriteLine("абс откл : " + ((1/num)*sr3));

        } 


    }
}
