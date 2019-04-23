using System;
using System.Collections.Generic;
using System.Text;
using Weiterbilden.Aufgaben_Privat.Personenliste;

namespace Weiterbilden.Aufgaben_Privat.Personenliste.PersonHinzu
{
    class Registrierung
    {

        public static void PersonHinzuf()
        {

            string[] Names = new string[2];
            int Alter = 0;

            Console.Clear();

            Console.WriteLine("\t\tPerson Hinzufügen");

            Console.Write("Bitte geben Sie den Vorname ein: ");
            Names[0] = Convert.ToString(Console.ReadLine());
        
            // Throw Exception kommt, wenn ich mein Wissen darüber erweitert habe

            Console.Write("Bitte geben Sie den Nachname ein: ");
            Names[1] = Convert.ToString(Console.ReadLine());

            Console.Write("Geben Sie das Alter der Person ein: ");
            Alter = Convert.ToInt32(Console.ReadLine());

            PersonenListeMain Daten = new PersonenListeMain(Names[0], Names[1], Alter);
            


        }

    }
}
