using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBot
{
    internal class Graphics
    {

        private static int origRow = Console.CursorTop;
        private static int origCol = Console.CursorLeft;

        private static void DrawRectangle()
        {
            Console.Clear();

            // Draw the left side of a 5x5 rectangle, from top to bottom.
            for (int i = 0; i < 10; i++)
            {
                WriteAt(" ", 0, i);
            }

            // Draw the bottom side, from left to right.
            for (int i = 0; i < 60; i++)
            {
                WriteAt(" ", i, 9);
            }

            // Draw the right side, from bottom to top.
            for (int i = 10; i-- > 0;)
            {
                WriteAt(" ", 60, i);
            }

            // Draw the top side, from right to left.
            for (int i = 60; i-- > 0;)
            {
                WriteAt(" ", i, 0);
            }

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine();
        }

        public static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public static void DrawRec(int XTop, int YTop, int XBot, int YBot, ConsoleColor Color)
        {
            for (int y = YTop; y < YBot; y++)
            {
                for (int x = XTop; x < XBot; x++)
                {
                    Draw(x, y, Color);
                }
            }
        }

        private static void Draw(int x, int y, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = color;
            Console.Write(" ");
        }


    }
}
