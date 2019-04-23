using System;
using System.IO;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weiterbilden.Aufgaben_Privat.Minigame.Nebenklassen
{
    class Entscheidung
    {
        public static void Auswahl(int y)
        {

            switch (y)
            {
                case 1:

                    Console.Clear();
                    Console.WriteLine("\t\tAusgabe\n");
                    Console.WriteLine("Sie haben sich für Stein entschieden!");

                    break;

                case 2:

                    Console.Clear();
                    Console.WriteLine("\t\tAusgabe\n");
                    Console.WriteLine("Sie haben sich für Papier entschieden!");

                    break;

                case 3:

                    Console.Clear();
                    Console.WriteLine("\t\tAusgabe\n");
                    Console.WriteLine("Sie haben sich für Schere entschieden!");

                    break;

                case 4:

                    Console.Clear();
                    Console.WriteLine("\t\tAusgabe\n");
                    Console.WriteLine("Sie haben sich für Echse entschieden!");

                    break;

                case 5:

                    Console.Clear();
                    Console.WriteLine("\t\tAusgabe\n");
                    Console.WriteLine("Sie haben sich für Spock entschieden!");

                    break;
            }
        }

        public static void ComHand(int y)
        {

            string x;

            switch (y)
            {
                case 1:

                    x = "Stein";

                    MainGame.SetCOMHand(x);

                    break;

                case 2:

                    x = "Papier";

                    MainGame.SetCOMHand(x);

                    break;

                case 3:

                    x = "Schere";

                    MainGame.SetCOMHand(x);

                    break;

                case 4:

                    x = "Echse";

                    MainGame.SetCOMHand(x);

                    break;

                case 5:

                    x = "Spock";

                    MainGame.SetCOMHand(x);

                    break;
            }

        }

        public static void ChooseWinner(int y, int z)
        {

            // 1 = Stein 2 = Papier 3 = Schere 4 = Echse 5 = Spock
            // y = Player z = COM

            // Stein

            if(y == 1 && z == 4)
            {
                Console.WriteLine("\nDer Spieler gewinnt mit Stein!");
            }
            else if(y == 4 && z == 1)
            {
                Console.WriteLine("\nDer Computer gewinnt mit Stein!");
            }

            if(y == 1 && z == 3)
            {
                Console.WriteLine("\nDer Spieler gewinnt mit Stein!");
            }
            else if(y == 3 && z == 1)
            {
                Console.WriteLine("\nDer Computer gewinnt mit Stein!");
            }

            // Papier

            if(y == 2 && z == 1)
            {
                Console.WriteLine("\nDer Spieler gewinnt mit Papier!");
            }
            else if(y == 1 && z == 2)
            {
                Console.WriteLine("\nDer Computer gewinnt mit Papier!");

            }

            if(y == 2 && z == 5)
            {
                Console.WriteLine("\nDer Spieler gewinnt mit Papier!");
            }
            else if(y == 5 && z == 2)
            {
                Console.WriteLine("\nDer Computer gewinnt mit Papier!");
            }

            // Schere

            if(y == 3 && z == 4)
            {
                Console.WriteLine("\nDer Spieler gewinnt mit Schere!");
            }
            else if(y == 4 && z == 3)
            {
                Console.WriteLine("\nDer Computer gewinnt mit Schere!");

            }

            if(y == 3 && z == 2)
            {
                Console.WriteLine("\nDer Spieler gewinnt mit Schere!");
            }
            else if(y == 2 && z == 3)
            {
                Console.WriteLine("\nDer Computer gewinnt mit Schere!");
            }

            // Echse

            if(y == 4 && z == 5)
            {
                Console.WriteLine("\nDer Spieler gewinnt mit Echse!");
            }
            else if(y == 5 && z == 4)
            {
                Console.WriteLine("\nDer Computer gewinnt mit Echse!");
            }

            if(y == 4 && z == 2)
            {
                Console.WriteLine("\nDer Spieler gewinnt mit Echse!");
            }
            else if(y == 2 && z == 4)
            {
                Console.WriteLine("\nDer Computer gewinnt mit Echse!");
            }

            // Spock

            if(y == 5 && z == 1)
            {
                Console.WriteLine("\nDer Spieler gewinnt mit Spock!");
            }
            else if(y == 1 && z == 5)
            {
                Console.WriteLine("\nDer Computer gewinnt mit Spock!");
            }

            if(y == 5 && z == 3)
            {
                Console.WriteLine("\nDer Spieler gewinnt mit Spock!");
            }
            else if(y == 3 && z == 5)
            {
                Console.WriteLine("\nDer Computer gewinnt mit Spock!");
            }

            // Unentschieden

            if(y == z || z == y)
            {
                Console.WriteLine("\nUnentschieden! Diese Runde gewinnt niemand!");
            }


        }
    }
}
