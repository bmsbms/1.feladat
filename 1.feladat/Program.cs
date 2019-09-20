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
            
                int HanyElem;
                Console.WriteLine("Kérem adjan meg hogy hany darab számot szeretne megadni");
                HanyElem = Convert.ToInt32(Console.ReadLine());
                int[] tomb = new int[HanyElem];


            
            if (int.TryParse(Console.ReadLine(), out HanyElem))
            {
                Console.WriteLine("Kérem adjon meg {0} db számot", HanyElem);


                for (int i = 0; i < tomb.Length; i++)
                {
                    tomb[i] = Convert.ToInt32(Console.ReadLine());
                }

                int legnagyobb = tomb[0];
                int legkisebb = tomb[0];

                for (int i = 0; i < tomb.Length; i++)
                {
                    if (legnagyobb < tomb[i])
                    {
                        legnagyobb = tomb[i];
                    }

                    if (legkisebb > tomb[i])
                    {
                        legkisebb = tomb[i];
                    }

                }

            }
            else
            {
                Console.WriteLine("Nem számot adott meg");
            }
              
            


            Console.WriteLine("A legnagyobb szám a bekért adatok közül: {0} a legkisebb pedig {1}", legnagyobb, legkisebb);

            Console.ReadKey();

        }
    }
}
