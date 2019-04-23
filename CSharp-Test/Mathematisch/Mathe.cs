using System;
using System.Collections.Generic;
using System.Text;

namespace Weiterbilden.Aufgaben_Privat.Mathematisch
{
    class Mathe
    {

        static double Addi_erg, Kapital, Zinssatz, Dauer;
        static Int64[] x = new Int64[3];

        public Mathe(double _addi_erg)
        {
            Addi_erg = _addi_erg;
        }

        // The Constructor for the interest-calculation

        public Mathe(double _Kapital, double _Zinssatz, double _Dauer)
        {

            Kapital = _Kapital;
            Zinssatz = _Zinssatz;
            Dauer = _Dauer;

            AnzeigeZinseszins();

        }

        // The Constructor for the ... Calculation

        /*public Mathe(Int64 _Basis, Int64 _Exponent, Int64 _Summe)
        {
            x[0] = _Basis;
            x[1] = _Exponent;
            x[2] = _Summe;

            AnzeigePotenzrechnung(x[0], x[1], x[2]);

        }*/

        // Displays some values at the top of some programms

        private static void AnzeigeZinseszins()
        {

            Double[] x = new double[4];

            x[0] = Kapital;
            x[1] = Zinssatz;
            x[2] = Dauer;

            Console.Clear();

            Console.WriteLine("\t\tKapital: {0} Euro\t\tZinssatz: {1} Prozent\t\tDauer: {2} Jahre", x[0], x[1], x[2]);

        }


        /*private static void AnzeigePotenzrechnung(Int64 a, Int64 b, Int64 c)
        {

            Mathe Anzeige0 = new Mathe(a, b, c);

            Console.Clear();

            Console.WriteLine("\t\tBasis: {0}\t\tExponent: {1}\t\tSumme: {2}", a, b, c);

        }*/

        private static void AnzeigeQuadratzahlAbfrage(double a, double b, double c)
        {
            Console.Clear();

            Console.WriteLine("\t\tQuadratzahlen: {0}\t\tKorrekt: {1}\t\tFehler: {2}\n", a, b, c);

        }

        // Methods that are specifically made to return a value

        public static double ReturnPlus()
        {

            return Addi_erg;

        }

        // Methods

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

        public static void Potenzen()
        {

            Int64[] x = new Int64[4];

            Console.Clear();

            Console.WriteLine("\t\t Potenzrechnung");

            Console.Write("Geben Sie die Basis ein: ");
            x[0] = Convert.ToInt64(Console.ReadLine());

            Console.Write("Geben Sie den Exponenten ein: ");
            x[1] = Convert.ToInt64(Console.ReadLine());

            x[2] = x[0];

            for (int i = 1; i <= x[1]; i++)
            {

                Console.WriteLine("{0} hoch {1} lautet: {2}", x[0], i, x[2]);

                x[2] *= x[0];

            }

        }

        public static void Zinseszins()
        {

            Double[] x = new double[7];

            Console.Clear();


            do
            {

                Console.Write("\nGeben Sie ihr Kapital ein: ");
                x[0] = Convert.ToDouble(Console.ReadLine());

            } while (x[0] <= 0);

            Mathe Anzeige1 = new Mathe(x[0], 0, 0);

            do
            {

                Console.Write("\nGeben Sie den Zinssatz ein: ");
                x[1] = Convert.ToDouble(Console.ReadLine());

            } while (x[1] <= 0);

            Mathe Anzeige2 = new Mathe(x[0], x[1], 0);

            do
            {

                Console.Write("\nGeben Sie die Dauer ein: ");
                x[2] = Convert.ToDouble(Console.ReadLine());

            } while (x[2] <= 0);

            Mathe Anzeige3 = new Mathe(x[0], x[1], x[2]);

            // x[3] = Startkapital

            Console.WriteLine("{0}", x[6]);

        }

        public static void Quadratzahlabfrage()
        {

            double[] x = new double[6];

            Console.Clear();

            Console.WriteLine("\t\tQuadratzahl Abfrage");

            Console.Write("\nGeben Sie ein, bis welcher Quadratzahl Sie abgefragt werden möchten: ");
            x[0] = Convert.ToDouble(Console.ReadLine());

            AnzeigeQuadratzahlAbfrage(x[0], x[2], x[3]);

            for (int i = 1; i <= x[0]; i++)
            {

                Console.Write("Geben Sie die {0}. Quadratzahl ein: ", i);
                x[1] = Convert.ToDouble(Console.ReadLine());

                if (x[1] == i * i)                       //<---- If you did not make an mistake, the counter will go up and later be used as "Correct"
                {
                    x[2] += 1;
                }
                else                                    //<---- If you made an mistake, the counter will go up and later be used as "Mistake"
                {
                    x[3] += 1;
                }

                AnzeigeQuadratzahlAbfrage(x[0], x[2], x[3]);

            }

            Console.WriteLine("Von {0} Quadratzahlen, haben sie {1} richtig und {2} falsch beantwortet.\n", x[0], x[2], x[3]);

        }
    }
}
