using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace ConsoleBot
{
    internal class Program
    {

        static Bot anna = new Bot("Anna");

        static async Task Main(string[] args)
        {

            WelcomeMessage();
            await First();
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine(anna.Name + ": Velkommen!");
            Console.WriteLine(anna.Name + ": Spør meg om hva som helst ved å skrive inn noe nedenfor.");
        }

        public static async Task First()
        {
            List<string> userInputs = new List<string>();
            List<string> botAnswers = new List<string>();

            UserAndBotArrayValues(userInputs, botAnswers);

            await anna.Answer(userInputs, botAnswers);
        }
        
        public static void Second()
        {

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
            botAnswers.Add("Boten Anna, Anna heter jeg.");
            botAnswers.Add("Nej, jag er en bot.");
        }

    }
}

//Console.WriteLine(phrase.Contains("Academy"));
//Console.WriteLine(phrase.IndexOf('c'));
//Console.WriteLine(phrase.Substring(4, 3));
//Console.WriteLine(phrase.Substring(4));
