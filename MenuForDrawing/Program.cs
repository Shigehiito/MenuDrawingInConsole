using System.Diagnostics;

namespace MenuForDrawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int caseSwitch = 1;
            ConsoleKeyInfo input;

            int selectedButton = 1;

            DrawBorder();
            DrawButtons(selectedButton);

            do
            {
                input = Console.ReadKey(true);

                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selectedButton > 1)
                            selectedButton--; 
                        break;

                    case ConsoleKey.DownArrow:
                        if (selectedButton < 4)
                            selectedButton++; 
                        break;

                    case ConsoleKey.Enter:
                        Console.SetCursorPosition(0, Console.WindowHeight - 2);
                        Console.WriteLine($"Gomb {selectedButton} kiválasztva!");
                        break;

                    case ConsoleKey.Escape:
                        break;
                }

                DrawButtons(selectedButton);

            } while (input.Key != ConsoleKey.Escape); 

            static void DrawBorder()
            {
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

            do
            {
                switch (caseSwitch)
                {
                    case 1:
                        DrawBorder();
                        break;

                    case (int)ConsoleKey.Escape:
                        break;
                }
                input = Console.ReadKey(true);

            } while (input.Key != ConsoleKey.Escape);

            static void DrawButtons(int selectedButton)
            {
                string[] buttons = { "Gomb 1", "Gomb 2", "Gomb 3", "Gomb 4" };

                int buttonWidth = 14;
                int buttonHeight = 4;
                int verticalSpacing = 2;

                int startX = (Console.WindowWidth - buttonWidth) / 2;
                int startY = (Console.WindowHeight - (buttons.Length * (buttonHeight + verticalSpacing))) / 2;

                for (int i = 0; i < buttons.Length; i++)
                {
                    int buttonPosY = startY + i * (buttonHeight + verticalSpacing);

                    Console.SetCursorPosition(startX, buttonPosY);
                    Console.Write('╔');
                    for (int j = 1; j <= buttonWidth - 2; j++)
                    {
                        Console.Write('═');
                    }
                    Console.Write('╗');

                    Console.SetCursorPosition(startX, buttonPosY + 1);
                    Console.Write('║');

                    if (i + 1 == selectedButton)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    int textPadding = (buttonWidth - buttons[i].Length - 2) / 2;
                    Console.Write(new string(' ', textPadding) + buttons[i] + new string(' ', buttonWidth - buttons[i].Length - 2 - textPadding));
                    Console.ResetColor();
                    Console.Write('║');

                    Console.SetCursorPosition(startX, buttonPosY + 2);
                    Console.Write('╚');
                    for (int j = 1; j <= buttonWidth - 2; j++)
                    {
                        Console.Write('═');
                    }
                    Console.Write('╝');
                }
            }
        }
    }
}
