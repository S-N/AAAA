using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            double j = 2.5;
            j = i;
            Console.WriteLine(i);

            string s = "(´･ω･｀)";
            string k = "(｀・ω・´)";

            string x = string.Format("({0},{1})", s, k);
            Console.WriteLine(x);

            int[] hai = new[]{1,2,3,4,5};
            iminaiyone(hai);
 

        }

        private static void iminaiyone(int[] hai)
        {
            foreach (var item in hai)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
