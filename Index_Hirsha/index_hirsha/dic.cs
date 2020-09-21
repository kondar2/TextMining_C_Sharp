using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace index_hirsha
{
    class dic
    {
        Dictionary<int, int> stat = new Dictionary<int, int>();


        
        public void IndHirsha(KeyValuePair<int,int> sa)
        {
            int first = 0;
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

            Console.WriteLine(first + " - " + sec + "\n");
        }

    }
}
