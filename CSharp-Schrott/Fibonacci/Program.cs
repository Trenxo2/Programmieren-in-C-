using System;

namespace F_Folge
{
    class Program
    {

        private static void Calculation(int x)
        {
            int Zahl1 = 0, Zahl2 = 1, erg = 0;

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("{0}. Fibonacci Zahl: {1}\n", i, erg);

                Zahl1 += 1;
                Zahl2 += 1;

                Zahl1 = Zahl2;
                Zahl2 = erg;
                
                erg = Zahl1 + Zahl2 - 1;
            }
        }

        static void Main(string[] args)
        {
            Calculation(15);
        }
    }
}
