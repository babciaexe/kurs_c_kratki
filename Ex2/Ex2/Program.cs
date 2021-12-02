using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = new Dictionary<int, int>()
            {{1, 30},
             {2, 180},
             {3, 600}};
            var time = 0;
            Console.WriteLine("Welcome to timer application!\n");
            while (true)
            {
                Console.WriteLine("\nPick Time: \n1. 30 seconds \n2. 3 minutes \n3. 10 minutes \n4. Custom value \nPress escape to quit");
                var option = GetOption();
                if (option == 0)
                {
                    break;
                }
                if (option == 4)
                {
                    time = GetCustomTime();
                }
                Console.Clear();
                Console.WriteLine("Time start!");
                if (time != 0)
                {
                    Counting(time);
                }
                else
                {
                    times.TryGetValue(option, out time);
                    Counting(time);
                }
                PlaySong();
                Console.Clear();
                Console.WriteLine("Do you want to set up new timer? \nPress escepe to quit or any other key to continue");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
                Console.Clear();
            }
        }

        private static int GetCustomTime()
        {
            int time;
            while (true)
            {
                Console.WriteLine("\nType the time in seconds");
                var inputTime = Console.ReadLine();
                if (int.TryParse(inputTime, out time))
                {
                    if (time < 6039)
                    {
                        break;
                    }
                    Console.WriteLine("The time cannot be greather than 6 039 seconds");
                }
                Console.WriteLine("\nPlease type correct value");
            }
            return time;
        }

        static int GetOption()
        {
            int option;
            int[] options = {1, 2, 3, 4};
            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.Escape)
                {
                    option = 0;
                    break;
                }
                ;
                if (int.TryParse(input.KeyChar.ToString(), out option) && options.Contains(option))
                {
                    break;
                }
                Console.WriteLine("\nPlease type correct value");
                
            }
            return option;
        }

        static void Counting(int time)
        {
            while (true)
            {
                int minutes = time / 60;
                int seconds = time - (minutes * 60);
                Console.SetCursorPosition(0, Console.CursorTop);
                if (minutes < 10 && seconds < 10)
                {
                    Console.Write($"0{minutes}:0{seconds}");
                }
                else if (minutes < 10 && seconds >= 10)
                {
                    Console.Write($"0{minutes}:{seconds}");
                }
                else if (minutes >= 10 && seconds < 10)
                {
                    Console.Write($"{minutes}:0{seconds}");
                }
                else if (minutes >= 10 && seconds >= 10)
                {
                    Console.Write($"{minutes}:{seconds}");
                }
                
                Thread.Sleep(997);
                if (time <= 0) { break; }
                time -= 1;
            }
            Console.WriteLine("\nALARM! ALARM! ALARM!");
        }

        static void PlaySong()
        {
            {
                Console.Beep(1320, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 250); Console.Beep(1320, 125); Console.Beep(1188, 125); Console.Beep(1056, 250); Console.Beep(990, 250); Console.Beep(880, 500); Console.Beep(880, 250); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 750); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500);
            }
        }
    }
}
