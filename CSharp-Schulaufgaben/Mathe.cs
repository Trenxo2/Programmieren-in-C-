using System;
using System.Collections.Generic;
using System.Text;

namespace Weiterbilden.Aufgaben_Privat.Mathematisch
{
    class Mathe
    {

        static double Addi_erg, Kapital, Zinssatz, Dauer;

        public Mathe(double _addi_erg)
        {
            Addi_erg = _addi_erg;
        }

        public static double ReturnPlus()
        {

            return Addi_erg;

        }

        // Der Konstruktor für die Zinsrechnung

        public Mathe(double _Kapital, double _Zinssatz, double _Dauer)
        {

            Kapital = _Kapital;
            Zinssatz = _Zinssatz;
            Dauer = _Dauer;

            Anzeige();

        }

        // Die Anzeige für den Zinsrechner

        public static void Anzeige()
        {

            Double[] x = new double[4];

            x[0] = Kapital;
            x[1] = Zinssatz;
            x[2] = Dauer;

            Console.Clear();
            Console.WriteLine("\t\tKapital: {0}\tZinssatz: {1}\tDauer: {2}", x[0], x[1], x[2]);

        }

        public static void Addition()
        {

            Int64[] x = new Int64[2];
            double[] y = new double[5];

            Console.Clear();

            Console.WriteLine("\t\t Die Addition");

            Console.Write("Wie oft möchten Sie Zahlen addieren: ");
            x[0] = Convert.ToInt64(Console.ReadLine());

            for(int i = 1; i <= x[0]; i++)
            {
                y[0] += 1;

                Console.Write("Geben Sie die {0}. Zahl ein: ", y[0]);
                y[1] = Convert.ToDouble(Console.ReadLine());

                y[2] += y[1];

            }

            Mathe addi_erg = new Mathe(y[2]);

            Console.WriteLine("\nDie Summe aller Addierten Zahlen lautet: {0}", y[2]);

        }

        public static void ZinsesZins()
        {

            Double[] x = new double[7];

            Console.Clear();

            Console.Write("\nGeben Sie ihr Kapital ein: ");
            x[0] = Convert.ToDouble(Console.ReadLine());

            Mathe Anzeige1 = new Mathe(x[0], 0, 0);

            Console.Write("\nGeben Sie den Zinssatz ein: ");
            x[1] = Convert.ToDouble(Console.ReadLine());

            Mathe Anzeige2 = new Mathe(x[0], x[1], 0);

            Console.Write("\nGeben Sie die Dauer ein: ");
            x[2] = Convert.ToDouble(Console.ReadLine());

            Mathe Anzeige3 = new Mathe(x[0], x[1], x[2]);

            // x[3] = Startkapital

            x[3] = x[0];

            //

            x[4] = x[1] / 100;

            x[5] = 1 + x[4];


            Console.WriteLine("{0}", x[5]);

        }
    }
}
