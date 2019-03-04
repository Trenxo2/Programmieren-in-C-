using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    class Quadratzahlabfrage
    {

        // Konfiguration

        // Konstruktor
        
        private static void nz()
        {

            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine("\n");
            }

        }

        public static void Abfrage()
        {

            Console.Clear();
            Console.Title = "Quadratzahlabfrage";

            Int64[] eingabe = new Int64[5];

            Console.Write("\nBis zur welchen Zahl möchten Sie abgefragt werden: ");
            eingabe[0] = Convert.ToInt64(Console.ReadLine());

            for(int i = 1; i <= eingabe[0]; i++)
            {

                eingabe[1] += 1;

                Console.Write("Geben Sie die {0}. Quadratzahl ein: ", i);
                eingabe[2] = Convert.ToInt64(Console.ReadLine());

                if(eingabe[2] == eingabe[1] * eingabe[1])
                {
                    Console.WriteLine("\nDas Ergebnis war korrekt!\n");
                    eingabe[3] += 1;
                }
                else
                {
                    Console.WriteLine("\nDas Ergebnis war nicht korrekt!\n");
                    eingabe[4] += 1;
                }

            }

            Console.WriteLine("\nVon {0} Quadratzahlen hatten Sie {1} korrekt und {2} falsch!\n", eingabe[0], eingabe[3], eingabe[4]);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");

        }

    }
}
