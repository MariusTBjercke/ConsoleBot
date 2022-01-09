using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace ConsoleBot
{
    internal class Program
    {

        public static Bot anna = new Bot("Anna");

        static async Task Main(string[] args)
        {
            WelcomeMessage();
            await First();
        }

        public static void WelcomeMessage()
        {
            anna.Reply("Velkommen!");
            anna.Reply("Spør meg om hva som helst ved å skrive inn noe nedenfor.");
        }

        public static async Task First()
        {
            await anna.Answer();
        }
        
        public static async Task Second(string condition)
        {
            switch (condition)
            {
                case "hva med deg":
                {
                    anna.Reply("Hva med deg?");
                    break;
                }
                case "hva heter du":
                {
                    await anna.SimulateDots();
                    anna.Reply("Hva heter du, da?");
                    break;
                }
                default:
                {
                    break;
                }
            }
            await anna.Answer();
        }
        
        public static void Third()
        {

        }

        private static void UserAndBotArrayValues(List<string> userInputs, List<string> botAnswers)
        {
            // User
            userInputs.Add("Hei");
            userInputs.Add("Hvordan har du det");
            userInputs.Add("Hvem er du");
            userInputs.Add("Er du en båt?");

            // Bot
            botAnswers.Add("Hallois!");
            botAnswers.Add("Bare bra. Hva med deg?");
            botAnswers.Add("Boten Anna, Anna heter jag.");
            botAnswers.Add("Nej, jag er en bot.");
        }

    }
}

//Console.WriteLine(phrase.Contains("Academy"));
//Console.WriteLine(phrase.IndexOf('c'));
//Console.WriteLine(phrase.Substring(4, 3));
//Console.WriteLine(phrase.Substring(4));
