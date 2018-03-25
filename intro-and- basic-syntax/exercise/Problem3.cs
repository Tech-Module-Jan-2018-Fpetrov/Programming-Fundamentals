using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Receive from the Console the miles - as double type.
            double mi = double.Parse(Console.ReadLine());

            //Convert miles to kilometers. 
            //Use the note that 1 mile == 1.60934 km by default! Calculate..
            var km = mi * 1.60934;

            //Print the calculated km on the console. 
            Console.WriteLine("{0:F2}", km);
        }
    }
}
    
