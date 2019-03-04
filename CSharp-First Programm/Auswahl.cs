using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Auswahl
    {

        public static void Programmauswahl()
        {

            int[] eingabe = new int[20];

            Console.Clear();
            // Hier wird das Programm dementsprechende Programm ausgeführt

            Console.WriteLine("\n1.Taschenrechner\n2.Flächen- und Volumenrechnung\n3.Quadratwurzelabfrage\n4.ArrayLists");
            Console.Write("\nGeben Sie nun ein welches Programm Sie nutzen möchten: ");

            eingabe[0] = Convert.ToInt32(Console.ReadLine());

            switch (eingabe[0])
            {

                case 1:

                    Console.Clear();

                    Console.WriteLine("\n1.Addition\n2.Subtraktion\n3.Division\n4.Multiplikation\n5.Potenzrechnung");
                    Console.Write("\nGeben Sie nun ein welches Programm Sie nutzen möchten: ");

                    eingabe[1] = Convert.ToInt32(Console.ReadLine());

                    // Ab hier werden Funktionen/Methoden aufgerufen
                    switch (eingabe[1])
                    {

                        case 1:

                            Rechnungen.Addi();

                            break;

                        case 2:

                            Rechnungen.Subtr();

                            break;

                        case 3:

                            Rechnungen.Divi();

                            break;

                        case 4:

                            Rechnungen.Mlti();

                            break;

                        case 5:

                            Rechnungen.Ptz();

                            break;
                    }

                    break;

                case 2:

                    Console.Clear();
                    Console.WriteLine("\t\tFlächen- und Volumenbrechnung");

                    Hauptklasse.cstm_nz(2);

                    Console.WriteLine("\n1.Flächenberechnung\n2.Volumenberechnung");

                    Console.Write("\nGeben Sie an was Sie berechnen möchten: ");

                    eingabe[2] = Convert.ToInt32(Console.ReadLine());

                    // Switch-Case Anweisung für die Flächen- & Volumen Berechnung


                    switch (eingabe[2])
                    {

                        // Hier wird die Fläche berechnet.
                        case 1:

                            Console.Clear();
                            Console.WriteLine("\t\tFlächenberechnung\n");

                            Console.WriteLine("\n1.Rechteck-\n2.Viereck-\n3.Dreieck-\n4.Kreisfläche");
                            Console.Write("Suchen Sie sich eines der Rechenarten aus: ");

                            eingabe[3] = Convert.ToInt32(Console.ReadLine());

                            switch (eingabe[3])
                            {

                                case 1:

                                    Rechnungen.Reck();

                                    break;

                                case 2:

                                    Rechnungen.Veck();

                                    break;

                                case 3:

                                    Rechnungen.Deck();

                                    break;

                                case 4:

                                    Rechnungen.Kreis();

                                    break;

                            }

                            break;

                        //Hier wird das Volumen berechnet
                        case 2:

                            Console.Clear();
                            Console.WriteLine("\t\tVolumenberechnung");

                            Console.WriteLine("\n1.Rechteck-\n2.Viereck-\n3.Kreisvolumen");
                            Console.Write("\nSuchen Sie sich eines der Rechenarten aus: ");

                            eingabe[4] = Convert.ToInt32(Console.ReadLine());

                            switch (eingabe[4])
                            {

                                case 1:

                                    Rechnungen.VolReck();

                                    break;

                                case 2:

                                    Rechnungen.VolVeck();

                                    break;

                                case 3:

                                    Rechnungen.VolKreis();

                                    break;

                            }

                            break;
                    }
                    break;
                // Hier werden Quadratzahlen abgefragt
                case 3:
                    
                    double[] input = new double[1], erg = new double[1];

                    Console.Clear();
                    Console.WriteLine("\nQudratwurzelabfrage");

                    Console.Write("\nGeben Sie ein wie viele Qudratwurzeln Sie berechnen möchten: ");

                    input[0] = Convert.ToDouble(Console.ReadLine());

                    Rechnungen.Qdrzahl(input[0]);

                    break;

                case 4:

                    alist.ArrayListe();

                    break;
                }                   
            }
        }

    }
