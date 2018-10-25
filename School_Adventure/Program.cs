using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            int darabszam;
            int beker;
            int max = 0;
            Console.Write("Adja meg hány számot szeretne megadni: ");
            darabszam = Convert.ToInt32(Console.ReadLine());
            int[] szamok = new int[darabszam];

            for (int i = 0; i < szamok.Length; i++)
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
            Console.ReadLine();

        }
    }
}
