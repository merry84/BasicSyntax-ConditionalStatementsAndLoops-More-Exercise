using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Create a method that returns the English spelling of the last digit of a given number.
           // Write a program that reads an integer and prints the returned value from this method
           int num = int.Parse(Console.ReadLine());
            if (num % 10 == 1)
            {
                Console.WriteLine("one");
            }
            else if (num % 10 == 2) { Console.WriteLine("two"); }
            else if (num % 10 == 3) { Console.WriteLine("three"); }
            else if (num % 10 == 4) { Console.WriteLine("four"); }
            else if (num % 10 == 5) { Console.WriteLine("five"); }
            else if (num % 10 == 6) { Console.WriteLine("six"); }
            else if (num % 10 == 7) { Console.WriteLine("seven"); }
            else if (num % 10 == 8) { Console.WriteLine("eight"); }
            else if (num % 10 == 9) { Console.WriteLine("nine"); }
            else if (num % 10 == 0) { Console.WriteLine("zero"); }


        }
    }
}
