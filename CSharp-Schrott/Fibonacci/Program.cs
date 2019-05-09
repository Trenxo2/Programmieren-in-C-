using System;

namespace F_Folge
{
    class Program
    {

        private static void Calculation(int x)
        {
            int erste = 0, zweite = 1, erg = 0;

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("{0}. Fibonacci Zahl: {1}\n", i, erg);

                erste += 1;
                zweite += 1;

                erste = zweite;
                zweite = erg;
                
                erg = erste + zweite - 1;
            }
        }

        static void Main(string[] args)
        {
            Calculation(15);
        }
    }
}
