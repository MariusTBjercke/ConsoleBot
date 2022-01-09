using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleBot
{
    public class Bot
    {

        static string Name;

        public Bot(string name)
        {
            Name = name;
        }

        public async Task Answer()
        {
            Console.Write("User: ");

            // Convert to lowercase and remove question marks
            var userInput = Console.ReadLine().ToLower().Replace("?", "");

            // Wait for bot to answer
            await SimulateDots();

            switch (userInput)
            {
                case "hei":
                case "hallo":
                case "hallois":
                {
                    Reply("Hei på deg!");
                    break;
                }
                case "hvordan går det":
                case "hvordan har du det":
                case "står det bra til":
                {
                    Reply("Her går det bare fint!");
                    await Program.Second("hva med deg");
                    break;
                }
                case "hvem er du":
                case "hva heter du":
                case "hva er ditt navn":
                {
                    Reply("Boten Anna, Anna heter jag.");
                    await Program.Second("hva heter du");
                        break;
                }
                case "er du en båt":
                case "er du et fly":
                case "er du et menneske":
                case "er du en person":
                {
                    Reply("Nej, jag är en bot.");
                    break;
                }
                default:
                {
                    Reply("Jeg forstod ikke spørsmålet ditt, vennligst prøv igjen.");
                    await Answer();
                    break;
                }
            }
        }

        public void Reply(string reply)
        {
            Console.WriteLine(Name + ": " + reply);
        }

        public async Task SimulateDots()
        {
            string dots = "...";

            int rounds = 2;

            for (int i = 0; i < rounds; i++)
            {

                for (int j = 0; j < dots.Length; j++)
                {
                    Console.Write(dots[j]);
                    await Task.Delay(100);
                }

                await Task.Delay(200);

                Console.Write("\r   \r");

                await Task.Delay(200);

            }
        }

    }

}
