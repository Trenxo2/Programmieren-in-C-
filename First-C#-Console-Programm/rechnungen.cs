using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
    class Rechnungen
    {
        // Hier werden alle Standard Rechenmethoden programmiert

        private const double PI = 3.14159265359;

        public static void Addi()
        {
            double[] input = new double[2], erg = new double[1];

            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\t\tDer Additionsrechner\n");

            Console.Write("Geben Sie ein wie oft Sie eine Zahl Addieren möchten: ");

            input[0] = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= input[0]; x++)
            {

                Console.Write("\nGeben Sie den {0}. Wert ein: ", x);
                input[1] = Convert.ToDouble(Console.ReadLine());

                erg[0] += input[1];
            }

            Console.WriteLine("\nDie Summe aller Zahlen lautet: {0}", erg[0]);

        }

        public static void Subtr()
        {
            double[] input = new double[3], erg = new double[1];

            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\t\tDer Subtrakionsrechner\n");

            Console.Write("Geben Sie ein wie Sie eine Zahl Subtrahieren möchten: ");
            input[0] = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= input[0]; x++)
            {

                Console.Write("\nGeben Sie den {0}. Wert ein: ", x);
                input[1] = Convert.ToDouble(Console.ReadLine());

                erg[0] -= input[1];

            }

            Console.WriteLine("\nDie Summe aller Subtrahierten Zahlen lautet: {0}", erg[0]);

        }

        public static void Divi()
        {

            double[] input = new double[2], erg = new double[1];

            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\t\tDer Divisionsrechner");

            Console.Write("Geben Sie den 1. Wert ein, den Sie Dividiren möchten: ");
            input[4] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie den 2. Wert ein, den Sie Dividiren möchten: ");
            input[5] = Convert.ToDouble(Console.ReadLine());

            erg[2] = input[4] / input[5];

            Console.WriteLine("\nIhr Ergebnis lautet dank der Formel {0} / {1} = {2}\n", input[4], input[5], erg[2]);

        }

        public static void Mlti()
        {
            double[] input = new double[2], erg = new double[1];

            Console.WriteLine("\n");
            Console.WriteLine("\t\tDer Multiplikationsrechner");

            Console.Write("Geben Sie den 1. Wert ein, den Sie Multiplizieren möchten: ");
            input[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geben Sie den 2. Wert ein, den Sie Multiplizieren möchten: ");
            input[1] = Convert.ToDouble(Console.ReadLine());

            erg[0] = input[1] * input[2];

            Console.WriteLine("\nIhr Ergebnis lautet dank der Formel {0} * {1} = {2}\n", input[0], input[1], erg[0]);

        }

        // Hier werden die Flächenberechnungen/Volumenbrechnungen programmiert

        public static void Reck()
        {

            double[] input = new double[2], erg = new double[1];

            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\t\tDie Rechteckfläche");

            Console.Write("\nGeben Sie die Seite A ein: ");

            input[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nGeben Sie die Seite B ein: ");

            input[1] = Convert.ToDouble(Console.ReadLine());

            erg[0] = input[0] * input[1];

            Console.WriteLine("\nIhr Ergebnis lautet Aufgrund der Formel {0} * {1} : {2} cm²", input[0], input[1], erg[0]);

        }

        public static void Veck()
        {

            double[] input = new double[1], erg = new double[1];

            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\t\tDie Viereckfläche");

            Console.Write("\nGeben Sie die Seite A ein: ");

            input[0] = Convert.ToDouble(Console.ReadLine());

            erg[0] = input[0] * input[0];

            Console.WriteLine("\nIhr Ergebnis lautet Aufgrund der Formel {0} * {1} : {2} cm²", input[0], input[0], erg[0]);

        }

        public static void Deck()
        {

            double[] input = new double[3], erg = new double[2];

            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\t\tDie Dreieckfläche");

            Console.Write("\nGeben Sie die Seite A ein: ");

            input[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nGeben Sie die Höhe H ein: ");

            input[1] = Convert.ToDouble(Console.ReadLine());

            erg[0] = 0.5 * input[0] * input[1];

            Console.WriteLine("\nIhr Ergebnis lautet Aufgrund der Formel 0.5 * {0} * {1} : {2} cm²", input[0], input[1], erg[0]);

        }
        
        public static void Kreis()
        {

            double[] input = new double[1], erg = new double[2];

            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\nDie Kreisfläche");

            Console.Write("\nGeben Sie den Wert r an: ");
            input[0] = Convert.ToDouble(Console.ReadLine());

            erg[0] = input[0] * input[0];

            erg[1] = PI * erg[0];

            Console.WriteLine("\nIhr Ergebnis lautet Aufgrund der Formel {0} * {1}² : {2} cm²", PI, input[0], erg[1]);



        }

        public static void VolReck()
        {

            double[] input = new double[3], erg = new double[1];

            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\nDas Rechteck Volumen");

            Console.Write("\nGeben Sie die Seite A an: ");
            input[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nGeben Sie die Seite B an: ");
            input[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nGeben Sie die Seite C an: ");
            input[2] = Convert.ToDouble(Console.ReadLine());

            erg[0] = input[0] * input[1] * input[2];

            Console.WriteLine("\nIhr Ergebnis lautet aufgrund der Formel {0} * {1} * {2} = {3}cm³\n", input[0], input[1], input[2], erg[0]);

        }

        public static void VolVeck()
        {

            double[] input = new double[3], erg = new double[1];

            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\nDas Viereck Volumen");

            Console.Write("\nGeben Sie die Seite A an: ");
            input[0] = Convert.ToDouble(Console.ReadLine());

            erg[0] = input[0] * input[0] * input[0] * input[0];

            Console.WriteLine("\nIhr Ergebnis lautet aufgrund der Formel {0} * {1} * {2} * {3} = {4}cm³\n", input[0], input[0], input[0], input[0], erg[0]);

        }

        public static void VolKreis()
        {
            double[] input = new double[2], erg = new double[2];

            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\nDas Kreis Volumen");

            Console.Write("\nGeben Sie den Wert r an: ");
            input[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nGeben Sie den Wert H an : ");
            input[1] = Convert.ToDouble(Console.ReadLine());

            erg[0] = input[0] * input[0];

            erg[1] = PI * erg[0] * input[1];

            Console.WriteLine("\nIhr Ergebnis lautet aufgrund der Formel {0} * {1}² * {2} = {3}cm³\n", PI, erg[0], input[1], erg[1]);


        }

        // Hier werden alle anderen wichtigen Rechnungen programmiert

        public static void Qdrzahl(double x)
        {

            double[] erg = new double[1], input = new double[1], run = new double[1];
            int[] fehler = new int[1], korrekt = new int[1];

            for(double y = 1; y <= x; y= y+1)
            {

                Console.Write("\nGeben Sie die {0}. Quadratzahl ein: ", y);

                run[0] = run[0] + 1;
                
                erg[0] = Convert.ToDouble(Console.ReadLine());

                if(erg[0] == run[0] * run[0])
                {

                    Console.WriteLine("\nIhre eingabe von {0} war korrekt!", erg[0]);
                    korrekt[0] += 1;

                }

                else
                {

                    Console.WriteLine("\nIhre Eingabe von {0} war inkorrekt!", erg[0]);
                    fehler[0] += 1;
                }

                if (y >= x)
                {

                    Console.WriteLine("\nSie haben von {0}. Quadratzahlen {1} Richtig und {2} Falsch eingegeben.", run[0], korrekt[0], fehler[0]);

                }

            }

        }

        public static void Ptz()
        {
            double[] input = new double[2], erg = new double[1];


            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine("\t\tDie Potenzrechung");

            Console.Write("\nGeben Sie die Basis ein: ");
            input[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nGeben Sie den Exponenten ein: ");
            input[1] = Convert.ToDouble(Console.ReadLine());

            erg[0] = 1;

            for (int x = 1; x <= input[1]; x++)
            {

                erg[0] *= input[0];

                Console.WriteLine("Ihr {0}. Ergebnis lautet: {1}", x, erg[0]);

            }


        }

    }
}

