//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). 
//The card faces should start from 2 to A. Print each card face in its four possible suits: 
//clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;
using System.Linq;

namespace PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main()
        {
            string[] suits = { "♣", "♦", "♥", "♠" };
            for (int card = 2; card <= 14; card++)
            {
                for (int i = 0; i < 4; i++)
                {
                    switch (card)
                    {
                        case 2: 
                            Console.Write("2{0}  ", suits[i]);
                            break;
                        case 3:
                            Console.Write("3{0}  ", suits[i]);
                            break;
                        case 4:
                            Console.Write("4{0}  ", suits[i]);
                            break;
                        case 5:
                            Console.Write("5{0}  ", suits[i]);
                            break;
                        case 6:
                            Console.Write("6{0}  ", suits[i]);
                            break;
                        case 7:
                            Console.Write("7{0}  ", suits[i]);
                            break;
                        case 8:
                            Console.Write("8{0}  ", suits[i]);
                            break;
                        case 9:
                            Console.Write("9{0}  ", suits[i]);
                            break;
                        case 10:
                            Console.Write("10{0} ", suits[i]);
                            break;
                        case 11:
                            Console.Write("J{0}  ", suits[i]);
                            break;
                        case 12:
                            Console.Write("Q{0}  ", suits[i]);
                            break;
                        case 13: 
                            Console.Write("K{0}  ", suits[i]);
                            break;
                        case 14:
                            Console.Write("A{0}  ", suits[i]);
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
