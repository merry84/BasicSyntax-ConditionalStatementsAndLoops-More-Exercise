using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;

namespace GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Create a program, which helps you buy the games.
            //   The valid games are the following games in this table:
            // Name Price   
            // OutFall 4                      $39.99
            // CS: OG                         $15.99
            // Zplinter Zell                  $19.99
            // Honored 2                      $59.99
            // RoverWatch                     $29.99
            // RoverWatch Origins Edition     $39.99

            //On the first line, you will receive your current balance – a floating-point number in the range[0.00…5000.00].
            //Until you receive the command "Game Time", you have to keep buying games.
            //When a game is bought, the user's balance decreases by the price of the game.

            //Additionally, the program should obey the following conditions:
            //• If a game the user is trying to buy is not present in the table above,
            //print "Not Found" and read the next line.
            // • If at any point, the user has $0 left, print "Out of money!" and end the program.
            // • Alternatively, if the user is trying to buy a game that they can't afford,
            //print "Too Expensive" and read the next line.
            // • If the game exists and the player has the money for it, print "Bought {nameOfGame}".

            //When you receive "Game Time", print the user's remaining money and total spent on games,
            //rounded to the 2nd decimal place

            double balance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double sumOfGame = 0;

            while (input != "Game Time")
            {
                double game = 0;
                if (input == "OutFall 4") { game = 39.99; }
                else if (input == "CS: OG") { game = 15.99; }
                else if (input == "Zplinter Zell") { game = 19.99; }
                else if (input == "Honored 2") { game = 59.99; }
                else if (input == "RoverWatch") { game = 29.99; }
                else if (input == "RoverWatch Origins Edition") { game = 39.99; }

                else { Console.WriteLine("Not Found"); input = Console.ReadLine(); continue; }


                if (game <= balance) { Console.WriteLine($"Bought {input}"); sumOfGame += game; balance -= game; }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;

                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"Total spent: ${sumOfGame:f2}. Remaining: ${balance:f2}");

        }
    }
}
