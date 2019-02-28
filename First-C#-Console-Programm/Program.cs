using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // Mit dieser Funktion kann der Entwickler bestimmen wie oft eine Neue Zeile ausgegeben werden soll. Hierfür muss einfach der Wert in der for-schleife von "4" in eine beliebige Zahl geändert werden.
        static void nz()
        {

            for (int x = 1; x < 4; x++)
            {
                Console.WriteLine("\n");
            }

        }
        // Mit dieser Funktion kann der Nutzer selber bestimmen wie oft eine Neue Zeile ausgegeben werden soll. 
        static void cstm_nz(int y)
        {

            for (int x = 1; x < y; x++)
            {
                Console.WriteLine("\n");
            }

        }

        static void Main(string[] args)
        {

            int[] eingabe = new int[5];

            double[] input = new double[20], erg = new double[10];

            // Console.WriteLine gibt den Text aus der in der Klammer steht, jedoch ist es nicht möglich in der Zeile eine Eingabe tätigen zu können

            Console.WriteLine("\t\tSelbst geschriebenes C# Lernprogramm\n");

            // Console.Write gibt einen Text aus und ermöglicht, nicht so wie .WriteLine, dass man noch in der Zeile eine Eingabe tätigen kann.

            Console.Write("Geben Sie eine Zahl ein: ");

            eingabe[0] = Convert.ToInt32(Console.ReadLine());

            // Typische if-schleife. Sollte man aus vorherigen Sprachen wie C oder C++ kennen.

            if (eingabe[0] > 100 || eingabe[0] < 0)
            {

                Console.WriteLine("Dies ist eine Ungültige Eingabe!");

                return;

            }
            else
            {

                Console.WriteLine("\nIhre Eingabe lautete: {0}\n", eingabe[0]);

                Console.WriteLine("\t\tWarnung: \n\t\tDezimalzahlen könnten das Programm zum Absturz bringen!\n");
                Console.WriteLine("\nMoechten Sie das Programm beenden?\n");
                Console.WriteLine("\n0.Ja(fürs beenden des Programmes)\n1.Nein(fürs weiterführen des Programmes)");

                Console.Write("\nGeben Sie eine der oben genannten Werte ein: ");

                eingabe[1] = Convert.ToInt32(Console.ReadLine());

                // Typische Switch-Case anweisung. Sollte man wie die if-schleife schon aus vorheringen Sprachen wie C oder C++ kennen.

                switch (eingabe[1])
                {

                    case 0:

                        Console.WriteLine("\nDas Programm wird nun beendent!\n");

                        break;

                    case 1:

                        Console.Clear();

                        Console.WriteLine("\n1.Taschenrechner");
                        Console.Write("\nGeben Sie nun ein welches Programm Sie nutzen möchten: ");

                        eingabe[2] = Convert.ToInt32(Console.ReadLine());

                        switch (eingabe[2])
                        {

                            case 1:

                                Console.Clear();

                                Console.WriteLine("\n1.Addition\n2.Subtraktion\n3.Division\n4.Multiplikation\n5.Potenzrechnung");
                                Console.Write("\nGeben Sie nun ein welches Programm Sie nutzen möchten: ");

                                eingabe[3] = Convert.ToInt32(Console.ReadLine());

                                // Ab hier werden Funktionen/Methoden aufgerufen
                                switch (eingabe[3])
                                {

                                    case 1:

                                        rechnungen.Addi();

                                        break;

                                    case 2:

                                        rechnungen.Subtr();

                                        break;

                                    case 3:

                                        rechnungen.Divi();

                                        break;

                                    case 4:

                                        rechnungen.Mlti();

                                        break;

                                    case 5:

                                        rechnungen.Ptz();

                                        break;
                                }

                                break;

                        }

                        break;

                }
            }
        }
    }
}

