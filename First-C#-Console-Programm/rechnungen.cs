using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class rechnungen
    {


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

