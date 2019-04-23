using System;
using System.Collections.Generic;
using System.Text;
using Weiterbilden.Aufgaben_Privat.Personenliste.PersonHinzu;

namespace Weiterbilden.Aufgaben_Privat.Personenliste
{
    class PersonenListeMain
    {
        public string[] Names = new string[2];
        public int Alter = 0;

        // Erster Konstruktor zur Personenregistrierung
        public PersonenListeMain(string VName, string NNamen, int PAlter)
        {

            if(VName == null)
            {
                VName = "Unbekannt";
            }
            else if(NNamen == null)
            {
                NNamen = "Unbekannt";
            }

            if(PAlter < 0 || Alter > 110)
            {
                PAlter = -1;
            }

            Names[0] = VName;
            Names[1] = NNamen;
            Alter = PAlter;
            

        }

        public static void PersonenListe()
        {

            int eingabe;

            Console.Clear();

            Console.WriteLine("\t\tPersonenlisten Programm");

            Console.WriteLine("\n1.Person hinzufügen\n2.Person Anzeigen\n3.");
            Console.Write("Eingabe: ");
            eingabe = Convert.ToInt32(Console.ReadLine());

            switch (eingabe)
            {
                case 1:

                    Registrierung.PersonHinzuf();

                    break;

                case 2:



                    break;
            }

        }


    }
}
