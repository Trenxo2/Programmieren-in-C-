using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    class Programme
    {

        // Konfiguration

        public int x, y;
        public static int generiertezahl;

        // Konsturktor

        public Programme(int _x, int _y)
        {

            x = _x;
            y = _y;

            Random zufall = new Random();

            generiertezahl = zufall.Next(x, y);

        }

        public static int getGenerierteZahl()
        {
            Console.WriteLine("\n Die Zufällig Generierte Zahl lautet: {0}", generiertezahl);

            return generiertezahl;
        }

        public static void Zufallsgenerator()
        {

            int[] x = new int[3];

            Random zufall = new Random();

            Console.Clear();

            Console.WriteLine("\t\tZufallsgenerator");

            Console.Write("\nGeben Sie die 1. Zahl ein: ");
            x[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nGeben Sie die 2. Zahl ein: ");
            x[1] = Convert.ToInt32(Console.ReadLine());

            Programme genZahl = new Programme(x[0], x[1]);

            Console.Clear();

            getGenerierteZahl();

        }

    }
}
