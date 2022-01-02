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
            bool repeat;
            int choicedTimeOption;

            Dictionary<string, int> timeOptions = new Dictionary<string, int>();
            timeOptions.Add("15 sekund", 15);
            timeOptions.Add("1 minuta", 60);
            timeOptions.Add("2 minuty", 180);
            timeOptions.Add("Inna wartość", 4);
            int TimeOptionsCount = timeOptions.Count;

            do
            {
                Console.WriteLine("*** Welcome in TIMER ***");
                Console.WriteLine();
                int minutes = 0;
                int seconds = 0;

                Console.WriteLine("Time options to choose:");
                int index = 0;
                foreach (var item in timeOptions)
                {
                    Console.WriteLine($"\t {index + 1} - {item.Key}");
                    index++;
                }

                Console.WriteLine();
                Console.Write("Type choosen option: ");
                GetChoicedTimeOption(out choicedTimeOption, TimeOptionsCount);

                choicedTimeOption--;

                int individualTime;

                if (choicedTimeOption == 3)
                {
                    Console.Write("Type your time in seconds: ");
                    GetChoiceIndividualTime(out individualTime);

                    if (timeOptions.ContainsKey("Inna wartość"))
                        timeOptions["Inna wartość"] = individualTime;
                }

                if (timeOptions.ElementAt(choicedTimeOption).Value < 60)
                {
                    minutes = 0;
                    seconds = timeOptions.ElementAt(choicedTimeOption).Value;
                }
                else
                {
                    minutes = timeOptions.ElementAt(choicedTimeOption).Value / 60;
                    seconds = timeOptions.ElementAt(choicedTimeOption).Value % 60;
                }

                Console.WriteLine();
                Console.WriteLine("You timer was started!");
                for (int i = timeOptions.ElementAt(choicedTimeOption).Value; i > 0; i--)
                {
                    Console.Write($"\r{minutes:D2}:{seconds:D2}");
                    Thread.Sleep(1000);

                    if (seconds == 0)
                    {
                        minutes--;
                        seconds = 60;
                    }
                    seconds--;
                }

                Console.WriteLine();
                Console.WriteLine("Time is up!!!");
                Console.Beep(700, 1000);


                Console.Write("If you want to exit press ESC:");
                int charOfEnd = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();
                if (charOfEnd == 27)
                    repeat = false;
                else
                    repeat = true;
            } while (repeat);


            static int GetChoicedTimeOption(out int choicedTimeOption, int TimeOptionsCount)
            {

                if (!Int32.TryParse(Console.ReadLine(), out choicedTimeOption))
                {
                    Console.Write("Wrong value! Type choosen option: ");
                    GetChoicedTimeOption(out choicedTimeOption, TimeOptionsCount);
                }
                else if (choicedTimeOption > TimeOptionsCount || choicedTimeOption <= 0)
                {
                    Console.Write("Wrong value! Type choosen option: ");
                    GetChoicedTimeOption(out choicedTimeOption, TimeOptionsCount);
                }
                return (choicedTimeOption);
            }

            static int GetChoiceIndividualTime(out int individualTime)
            {

                if (!Int32.TryParse(Console.ReadLine(), out individualTime))
                {
                    Console.Write("Wrong value! Type your time in seconds: ");
                    GetChoiceIndividualTime(out individualTime);
                }
                else if (individualTime <= 0)
                {
                    Console.Write("Wrong value! Type your time in seconds: ");
                    GetChoiceIndividualTime(out individualTime);
                }
                return (individualTime);
            }



            
        }



    }
}
