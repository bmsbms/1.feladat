using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tomb = new int[10];
            Console.WriteLine("Kérem adjon meg 10 db számot");
            

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }

            int legnagyobb=tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (legnagyobb < tomb[i])
                {
                    legnagyobb = tomb[i];
                }
            }


            Console.WriteLine("A legnagyobb szám a bekért adatok közül: {0}",legnagyobb);

            Console.ReadKey();

        }
    }
}
