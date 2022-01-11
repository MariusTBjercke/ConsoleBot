using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ConsoleBot
{
    internal class Program
    {

        public static Bot anna = new Bot("Anna");
        static BotGraphics botGraphics = new BotGraphics();
        public static Timer aTimer = new System.Timers.Timer();

        static async Task Main(string[] args)
        {
            await RunPreload();
            StartHintsInBg();
            await First();
        }

        private static void StartHintsInBg()
        {
            aTimer.Interval = 2000;
            aTimer.Elapsed += ShowHints;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        static async void ShowHints(object sender, ElapsedEventArgs e)
        {
            await anna.BotHints();
            aTimer.Enabled = false;
        }

        //Sytem.Timers.Timer();
        
        // Create a timer and set a two second interval.
        //aTimer = new System.Timers.Timer();
        //aTimer.Interval = 2000;

        //// Hook up the Elapsed event for the timer. 
        //aTimer.Elapsed += OnTimedEvent;

        //// Have the timer fire repeated events (true is the default)
        //aTimer.AutoReset = true;

        //// Start the timer
        //aTimer.Enabled = true;

        //Console.WriteLine("Press the Enter key to exit the program at any time... ");
        //Console.ReadLine();

        private static async Task RunPreload()
        {
            string inputText = @"
         ####         ###     ##  ###     ##         ####
        ##  ##        ####    ##  ####    ##        ##  ##
       ##    ##       ## ##   ##  ## ##   ##       ##    ##
      ##      ##      ##  ##  ##  ##  ##  ##      ##      ##
     ############     ##   ## ##  ##   ## ##     ############
    ##############    ##    ####  ##    ####    ##############
   ##            ##   ##     ###  ##     ###   ##            ##
  ##              ##  ##      ##  ##      ##  ##              ##

            ";

            await DrawBoxAndSeparateCharacters(inputText);

            await Task.Delay(3000);
            Console.Clear();

            await DrawBoxWithMessage("Velkommen!");
            await Task.Delay(3000);
            Console.Clear();
        }

        static async Task DrawBoxWithMessage(string inputText)
        {
            ConsoleColor bgColor = ConsoleColor.DarkGray;

            await DrawRectangle(70, 15, bgColor);

            Console.SetCursorPosition((70 - inputText.Length) / 2, 0);
            Console.Write(inputText);
        }

        private static async Task DrawBoxAndSeparateCharacters(string inputText)
        {

            ConsoleColor bgColor = ConsoleColor.DarkGray;

            await DrawRectangle(70, 15, bgColor);

            Console.SetCursorPosition(0, 0);
       
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            var annaArray = inputText.ToCharArray();

            foreach (var x in annaArray)
            {
                if (x == '#')
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(x);
                }
                else
                {
                    Console.BackgroundColor = bgColor;
                    Console.Write(x);
                }
            }

            Console.BackgroundColor = ConsoleColor.Black;

        }

        public static async Task DrawRectangle(int width, int height, ConsoleColor color)
        {
            for (int i = 0; i < width; i++) // Måtte bruke await Task.Delay(); så DrawRect fikk tid til å bygge seg ferdig ( ellers ble det hull i rektangelen ).
            {
                for (int j = 0; j < height; j++)
                {
                    botGraphics.Draw(i, j, color);
                }
                await Task.Delay(10);
            }
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
                    Console.Write("User: ");
                    string userInput = Console.ReadLine();
                    await anna.SimulateDots();
                    anna.Reply("Heisann, " + userInput + ". Hyggelig å hilse på deg!");
                    await anna.Answer();
                    break;
                }
                default:
                {
                    break;
                }
            }
            await anna.Answer();
        }
        
        public static void Third(string condition)
        {
            switch (condition)
            {
                case "":
                {
                    break;
                }
            }
        }

    }
}

// @"\b" + var + @"\b"
//Console.WriteLine(phrase.Contains("Academy"));
//Console.WriteLine(phrase.IndexOf('c'));
//Console.WriteLine(phrase.Substring(4, 3));
//Console.WriteLine(phrase.Substring(4));

//          ####         ###     ##  ###     ##         ####
//         ##  ##        ####    ##  ####    ##        ##  ##
//        ##    ##       ## ##   ##  ## ##   ##       ##    ##
//       ##      ##      ##  ##  ##  ##  ##  ##      ##      ##
//      ############     ##   ## ##  ##   ## ##     ############
//     ##          ##    ##    ####  ##    ####    ##          ##
//    ##            ##   ##     ###  ##     ###   ##            ##
//   ##              ##  ##      ##  ##      ##  ##              ##
//




                                    //@".......................,___,," + "\n" +
                                    //@"....................../´   /) " + "\n" +
                                    //@"...................../´¯. /) " + "\n" +
                                    //@"..................../.._ / " + "\n" +
                                    //@".................../¯.. / " + "\n" +
                                    //@"................../... / " + "\n" +
                                    //@"............./´¯/'...'/´¯¯`·¸ " + "\n" +
                                    //@"........../'/.../..../......./¨¯\ " + "\n" +
                                    //@"........('(...´...´.... ¯~/'...') " + "\n" +
                                    //@"........('(...´...´.... ¯~/'...') " + "\n" +
                                    //@".........\.................'...../ " + "\n" +
                                    //@"..........\................'...../ " + "\n" +
                                    //@"...........\................_.·´ " + "\n" +
                                    //@"............\..............( " + "\n" +
                                    //@"............|...............\..." + "\n"