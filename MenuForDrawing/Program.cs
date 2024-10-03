using System.Diagnostics;

namespace MenuForDrawing
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int caseSwitch = 1;
            Console.SetCursorPosition(0, 0);
            do
            {
                switch (caseSwitch)
                {
                    case ConsoleKey.Escape:
                        break;
                }

                Console.Write('╔');
                for (int i = 1; i <= Console.WindowWidth - 2; i++)
                {
                    Console.Write('═');
                }
                Console.Write('╗');
                for (int i = 1; i <= Console.WindowHeight - 2; i++)
                {
                    Console.WriteLine('║');
                }
                Console.Write('╚');
                for (int i = 1; i <= Console.WindowWidth - 2; i++)
                {
                    Console.Write('═');
                }
                Console.Write('╝');
                for (int i = 1; i <= Console.WindowHeight - 2; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth - 1, i);
                    Console.Write('║');
                }


            }
            while (input.Key != ConsoleKey.Escape);



        }
    }
}
