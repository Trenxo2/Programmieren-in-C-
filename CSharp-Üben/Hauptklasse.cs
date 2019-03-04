using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    class Hauptklasse
    {
        static void Main(string[] args)
        {

            int[] x = new int[2], input = new int[2];

            Random zufall = new Random();

            Console.Title = "Windows Konsolenanwendung";


            do
            {

                Console.WriteLine("\t\t Windows Konsolenanwendung\n\n");
                Console.WriteLine("\n1.Zufallsgenerator\n2.Person hinzufügen\n3.Person anzeigen\n0.Programm beenden");
                Console.Write("\nEingabe: ");

                input[0] = Convert.ToInt32(Console.ReadLine());

                switch (input[0])
                {

                    case 1:

                        Zufallsgenerator.random();

                        break;

                    case 2:

                        Personenliste.Perso_hinzu();

                        break;

                    case 3:

                        Personenliste.Perso_anzeigen();

                        break;
                }
            } while (input[0] > 0);
    }
   }
}