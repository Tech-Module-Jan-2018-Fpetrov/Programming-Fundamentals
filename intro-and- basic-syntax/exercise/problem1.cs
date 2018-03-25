using System;

namespace excercises_23._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the next four lines,we recieve four integers
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var fourNum = int.Parse(Console.ReadLine());
           
            //Prints the numbers in 4-digit debit card format
            Console.WriteLine($"{firstNumber:D4} {secondNum:D4} {thirdNum:D4} {fourNum:D4}");

        }
    }
}
