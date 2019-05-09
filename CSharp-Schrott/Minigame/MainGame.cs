using System;
using System.Collections.Generic;
using System.Text;
using Weiterbilden.Aufgaben_Privat.Minigame.Nebenklassen;

namespace Weiterbilden.Aufgaben_Privat.Minigame
{
    class MainGame
    {

        static int y;
        static string z;
        
        // Constructor, that converts the generated number to a computer descision
        
        public MainGame(int x)
        {
            y = x;

            Entscheidung.ComHand(y);

        }
        // Construcotr, that converts the generated number to a small piece of string example: Stone
        
        public MainGame(string x)
        {
            z = x;
        }
        
        // Generates a random number for Computer Oponent that will be later used for some more steps, like setting the descision and setting the output
        
        private static void Generator()
        {
            int xx = 0;
            Random zufall = new Random();

            for(int i = 1; i <= zufall.Next(100, 1500); i++)
            {

                xx = zufall.Next(1, 6);

                for(int j = 1; j <= zufall.Next(100, 725); j++)
                {

                    xx = zufall.Next(1, 6);

                }

            }

            MainGame ComNumber = new MainGame(xx);

        }
        
        // Sets the value of the generated Number as the Computer Hand 
        
        public static void SetCOMHand(string x)
        {

            MainGame COMHand = new MainGame(x);

        }

        public static void SPSES()
        {

            Console.Clear();

            int[] x = new int[3];

            Console.Write("Geben Sie ein, wie viele Runden Sie spielen möchten: ");
            x[1] = Convert.ToInt32(Console.ReadLine());

            x[2] = 1;

            do
            {

                Generator();
                x[2]++;

                Console.WriteLine("\n\t\tEingabe");

                Console.WriteLine("\n1.Stein\n2.Papier\n3.Schere\n4.Echse\n5.Spock");
                Console.Write("Ihre Eingabe: ");
                x[0] = Convert.ToInt32(Console.ReadLine());

                if (x[0] > 5 || x[0] < 0)
                {
                    do
                    {

                        Console.Clear();
                        Console.WriteLine("Ihre Eingabe {0} ist ungültig! Die Zahl darf nicht größer als 5 oder kleiner als 1 sein!", x[0]);

                        Console.Write("Eingabe: ");
                        x[0] = Convert.ToInt32(Console.ReadLine());

                    } while (x[0] > 5 || x[0] <= 0);
                }

                Entscheidung.Auswahl(x[0]);

                Console.WriteLine("\nDer Computer hat {0} ausgewählt!", z);

                Entscheidung.ChooseWinner(x[0], y);

            } while (x[2] <= x[1]);
        }

    }
}
