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

            Console.WriteLine("\t\t Windows Konsolenanwendung\n\n");

            Console.WriteLine("\n1.Zufallsgenerator\n2.Nafinrn");
            Console.Write("\nSuch Sie sich ein Programm aus(nur mit Zahlen): ");

            input[0] = Convert.ToInt32(Console.ReadLine());

            switch (input[0])
            {

                case 1:

                    Programme.Zufallsgenerator();

                    break;

            }
        }
    }
}