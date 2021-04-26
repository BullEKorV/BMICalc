using System;

namespace Ja
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till min BMI räknare");
                Console.WriteLine("Skriv in din höjd i cm");
                string height = Console.ReadLine();
                float cleanHeight;
                while (!float.TryParse(height, out cleanHeight))
                {
                    Console.Write("Skriv endast nummer: ");
                    height = Console.ReadLine();
                }
                Console.WriteLine("Skriv in din vikt i kilo");
                string weight = Console.ReadLine();
                float cleanWeight;
                while (!float.TryParse(weight, out cleanWeight))
                {
                    Console.Write("Skriv endast nummer: ");
                    weight = Console.ReadLine();
                }
                float bmi = (cleanWeight / ((cleanHeight / 100) * (cleanHeight / 100)));
                bmi = (float)Math.Round(bmi, 2);
                Console.WriteLine("------------------------------- \n");
                Console.WriteLine($"Ditt bmi är {bmi}");
                Console.WriteLine("\n-------------------------------");
                Console.Write("Tryck på valfri knapp om du vill fortsätta eller tryck på \"n\" följd av \"enter\" om du vill avsluta: ");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine("\n");
            }
        }
    }
}