using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Your average constumpion is {CalculateAvarageConsumption()}");

                Console.Write("Press <C> to continue or <X> to exit... ");
                if (Console.ReadKey().Key == ConsoleKey.X)
                {
                    break;
                }
                Console.Clear();
            }
        }
        static float CalculateAvarageConsumption()
        {
            float traveledKm, usedFuel;
            while (true)
            {
                Console.WriteLine("Type number of travbeled km");
                var traveledInput = Console.ReadLine();
                if (float.TryParse(traveledInput, out traveledKm) && traveledKm > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please use positive numbers to determine the number of km\n");
                }
            }
            while (true)
            {
                Console.WriteLine("Type number of used fuel in liters");
                var usedFuelInput = Console.ReadLine();
                if (float.TryParse(usedFuelInput, out usedFuel) && traveledKm > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please use positive numbers to determine the number of fuel\n");
                }
            }
            var averageConsumption = (traveledKm / 100) / usedFuel;
            return (averageConsumption);
        }
    }
}
