using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleBot
{
    public class Bot
    {

        public string Name;

        public Bot(string name)
        {
            Name = name;
        }

        public async Task Answer(List<string> inputs, List<string> answers)
        {

            Console.Write("User: ");
            var userText = Console.ReadLine().ToLower();

            // Wait for bot to answer
            await SimulateDots();

            bool success = true;

            for (int i = 0; i < inputs.Count; i++) // Count == Lister | Length == Arrays.
            {
                var input = inputs[i].ToLower();
                if (Regex.Match(userText, @"\b" + input + @"\b", RegexOptions.IgnoreCase).Success)
                {

                    Console.Write("Bot: ");
                    Console.WriteLine(answers[i]);

                    success = true;
                    break;
                }
                else
                {
                    success = false;
                }
            }

            if (!success)
            {
                Console.Write("Bot: ");
                Console.WriteLine("Hmm...");

            }

            await Answer(inputs, answers);

        }

        public static async Task SimulateDots()
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
