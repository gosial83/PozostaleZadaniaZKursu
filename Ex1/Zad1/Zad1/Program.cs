using System;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Witaj w programie obliczajacym śrdnie zućycie paliwa na 100 kilometrów. ***");
            Console.WriteLine();

            int traveled;
            int usedFuel;
            double averageConsumption;
            bool endCalculation;
            
            do
            {
                GetTraveled(out traveled);
                GetUsedFuel(out usedFuel);

                averageConsumption = CalculateAvarageConsumption(traveled, usedFuel);

                Console.WriteLine("Średnie spalanie wynosi {0:N2} litra na 100 km.", averageConsumption);
                Console.WriteLine();

                Console.Write("Liczmym raz jeszcze? Jeśli nie, naciśnij \"x\" ");
                if (Console.ReadKey().KeyChar == 'x')
                    endCalculation = true;
                else
                    endCalculation = false;

                Console.WriteLine();
                Console.WriteLine();

            } while (!endCalculation);

        }

        static double CalculateAvarageConsumption(int traveled, int usedFuel)
        { 
            return (double)usedFuel / traveled * 100;
        }

        static int GetTraveled(out int traveled)
        {
            Console.Write("Podaj liczbę przejechanych kilometrów: ");

            if (!Int32.TryParse(Console.ReadLine(), out traveled))
            {
                Console.WriteLine("Wprowadzono niepoprawną warość!!!");
                GetTraveled(out traveled);
            }
            
            return traveled;
        }

        static int GetUsedFuel(out int usedFuel)
        {
            Console.Write("Podaj zużyte paliwo w litrach: ");

            if (!Int32.TryParse(Console.ReadLine(), out usedFuel))
            {
                Console.WriteLine("Wprowadzono niepoprawną warość!!!");
                GetUsedFuel(out usedFuel);
            }

            return usedFuel;
        }



    }
}
