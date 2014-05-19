//Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen 
//and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly 
//fall down and you need to avoid a crash. Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed 
//with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace FallingRocks
{
    struct Element
    {
        public int CoordX;
        public int CoordY;
        public char Symbol;
        public ConsoleColor Color;
    }

    class FallingRocks
    {
        static void PrintOnPosition(int coordX, int coordY, char symbol, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(coordX, coordY);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        static void PrintStringOnPosition(int coordX, int coordY, string str, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(coordX, coordY);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main()
        {
            int playfieldWidth = 27;
            int livesCount = 3;
            int score = 0;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 50;
            Element dwarf = new Element();
            dwarf.CoordX = 13;
            dwarf.CoordY = Console.WindowHeight - 1;
            dwarf.Symbol = 'O';
            dwarf.Color = ConsoleColor.White;
            Random randomGenerator = new Random();
            List<Element> rocks = new List<Element>();

            while (true)
            {
                bool hitted = false;

                //Creating rocks
                {
                    Element newRock = new Element();
                    char[] symbol = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
                    int i = randomGenerator.Next(0, symbol.Length);
                    int assist = randomGenerator.Next(0, 100);
                    int rockLength;
                    if (assist < 70)
                    {
                        rockLength = 1;
                    }
                    else if (assist < 95)
                    {
                        rockLength = 2;
                    }
                    else
                    {
                        rockLength = 3;
                    }

                    newRock.CoordX = randomGenerator.Next(0, playfieldWidth);
                    newRock.Color = (ConsoleColor)randomGenerator.Next(9, 15);
                    newRock.CoordY = 0;
                    newRock.Symbol = symbol[i];

                    for (int j = 0; j < rockLength; j++)
                    {
                        newRock.CoordX = newRock.CoordX + 1;
                        if (newRock.CoordX < playfieldWidth)
                        {
                            rocks.Add(newRock);
                        }
                    }
                }

                // Move dwarf (key pressed)
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.CoordX - 1 >= 1)
                        {
                            dwarf.CoordX--;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.CoordX + 1 < playfieldWidth - 1)
                        {
                            dwarf.CoordX++;
                        }
                    }
                }

                // Move rocks
                List<Element> newList = new List<Element>();

                for (int i = 0; i < rocks.Count; i++)
                {
                    Element oldRock = rocks[i];
                    Element newRock = new Element();
                    newRock.CoordX = oldRock.CoordX;
                    newRock.CoordY = oldRock.CoordY + 1;
                    newRock.Symbol = oldRock.Symbol;
                    newRock.Color = oldRock.Color;

                    // Check if rocks are hitting dwarf
                    if (((newRock.CoordY == dwarf.CoordY) && (newRock.CoordX == (dwarf.CoordX - 1))) ||
                        ((newRock.CoordY == dwarf.CoordY) && (newRock.CoordX == dwarf.CoordX)) ||
                        ((newRock.CoordY == dwarf.CoordY) && (newRock.CoordX == (dwarf.CoordX + 1))))
                    {
                        livesCount--;
                        hitted = true;
                    }

                    if (newRock.CoordY < Console.WindowHeight)
                    {
                        newList.Add(newRock);
                    }
                    else
                    {
                        score++;
                    }
                }
                rocks = newList;

                // Clear the console
                Console.Clear();

                // Draw "Game over"
                if (livesCount <= 0)
                {
                    PrintStringOnPosition(17, 8, "GAME  OVER  !!!", ConsoleColor.Red);
                    PrintStringOnPosition(12, 16, "Your score is :" + score, ConsoleColor.Red);
                    PrintStringOnPosition(14, 24, "Press [Enter] to exit", ConsoleColor.Red);
                    Console.ReadLine();
                    return;
                }

                // Redraw playfield
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    PrintOnPosition(playfieldWidth, i, '|', ConsoleColor.White);
                }

                foreach (Element rock in rocks)
                {
                    PrintOnPosition(rock.CoordX, rock.CoordY, rock.Symbol, rock.Color);
                }

                if (hitted)
                {
                    PrintOnPosition(dwarf.CoordX, dwarf.CoordY, 'H', ConsoleColor.Red);
                    PrintOnPosition(dwarf.CoordX - 1, dwarf.CoordY, 'H', ConsoleColor.Red);
                    PrintOnPosition(dwarf.CoordX + 1, dwarf.CoordY, 'H', ConsoleColor.Red);
                    rocks.Clear();
                    PrintStringOnPosition(32, 3, "Press [Enter]", ConsoleColor.Green);
                    PrintStringOnPosition(33, 5, "to continue", ConsoleColor.Green);
                    Console.ReadLine();
                }
                else
                {
                    PrintOnPosition(dwarf.CoordX, dwarf.CoordY, dwarf.Symbol, dwarf.Color);
                    PrintOnPosition(dwarf.CoordX - 1, dwarf.CoordY, '(', dwarf.Color);
                    PrintOnPosition(dwarf.CoordX + 1, dwarf.CoordY, ')', dwarf.Color);
                }

                // Draw info
                PrintStringOnPosition(35, 8, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringOnPosition(33, 16, "Score: " + score, ConsoleColor.White);

                Thread.Sleep(250);
            }
        }
    }
}
