using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(CalculateAvarageConsumption());

                Console.Write("Press <C> to continue or <X> to exit... ");
                if(Console.ReadKey().Key == ConsoleKey.X)
                {
                    break;
                }
                Console.WriteLine("\n");
            }


        }
        static string CalculateAvarageConsumption()
        {
            string message;
            Console.WriteLine("Type number of travbeled km");
            var traveledInput = Console.ReadLine();
            Console.WriteLine("Type number of used fuel in liters");
            var usedFuelInput = Console.ReadLine();
            
            if (float.TryParse(traveledInput, out float traveled ) && float.TryParse(usedFuelInput, out float usedFuel))
            {
                float averageConsumption = (traveled / 100) / usedFuel ;
                message = $"{averageConsumption} Liters per 100km";
            }
            else 
            {
                message = "Please use correct info";
            }
            return (message);
        }
    }
}
