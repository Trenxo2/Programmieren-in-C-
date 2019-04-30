using System;
using System.Collections.Generic;
using System.Text;

namespace Weiterbilden.Aufgaben_Privat.Other
{
    class GeneratorTest
    {

        public static void GenTest()
        {
            double[] i = new double[3];

            Random rng = new Random();

            i[0] = 2;

            for(int x = 0; x <= i[0]; x++)
            {
                i[1] = rng.Next(1, 6);

                if(i[1] < 5)
                {
                    i[0] += 1;
                }
                else if(i[1] == 5)
                {
                    i[0] = x;
                }

                i[2] += 1;

            }

            Console.WriteLine("Es wurden {0} Versuch(e) benötigt um die Zahl 5 zu bekommen!", i[2]);

        }

    }
}
