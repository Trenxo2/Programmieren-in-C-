using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    class Personenliste
    {
        // Konfiguration
        static string vorname, nachname;
        static int alter;

        static ArrayList Auflistung = new ArrayList();

        // Konstruktor
        public Personenliste(string _vorname, string _nachname, int _alter)
        {
            vorname = _vorname;
            nachname = _nachname;
            alter = _alter;

            if(vorname == "")
            {
                vorname = "Unbekannt";

            }
            else if(nachname == "")
            {
                nachname = "Unbekannt";
            }

            if(alter <= 0 || alter >= 120)
            {
                alter = -1;
            }

        }

        private static int showData()
        {
            return 0;
        }

        private static int retData()
        {
            Console.Clear();

            Console.WriteLine("\t\t Diese Daten wurden hinzugefügt: ");

            Console.WriteLine("Vorname: {0}\nNachname: {1}\nAlter: {2}", vorname, nachname, alter);

            return alter;
        }

        public static void Perso_hinzu()
        {

            Console.Clear();

            string vorname = "", nachname = "";
            int alter;

            Console.WriteLine("\t\tPerson hinzufügen");

            Console.Write("\nWie heißt die Person mit Vornamen: ");
            vorname = Convert.ToString(Console.ReadLine());

            Console.Write("\nWas hat die Person für einen Nachnamen: ");
            nachname = Convert.ToString(Console.ReadLine());

            Console.Write("\nWie alt ist die Person: ");
            alter = Convert.ToInt32(Console.ReadLine());

            Personenliste test = new Personenliste(vorname, nachname, alter);

            retData();

        }

        public static void Perso_anzeigen()
        {

            showData();

        }

    }
}
