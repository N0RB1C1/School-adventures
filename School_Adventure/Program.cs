using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Adventure
{
    class Program
    {

        private static int[] szamok = new int[10];

        static void Main(string[] args)
        {
            int beker;
            int max = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Adja meg a/az {0}. számot:",i+1);
                beker = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                szamok[i] = beker;
                 
            }
            for (int i = 0; i < szamok.Length; i++)
            {
                if(szamok[i]> max)
                {
                    max = szamok[i];
                }
            }
            Console.Write("A legnagyobb elem: {0}", max);
            Console.ReadKey();

        }
    }
}
