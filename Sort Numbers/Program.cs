using System;

namespace Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives three real numbers and sorts them in descending order.
            //Print each number on a new line
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int maxNum = Math.Max(Math.Max(num1, num2), num3);
            int minNum = Math.Min(Math.Min(num1, num2), num3);
            int medNum = (num3 + num2 + num1)-(maxNum + minNum);
            Console.WriteLine(maxNum);
            Console.WriteLine(medNum);
            Console.WriteLine(minNum);

        }
    }
}
