using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        { 
            double miles = double.Parse(Console.ReadLine());
            var kilometers = miles * 1.60934;

            Console.WriteLine("{0:F2}", kilometers);

        }
    }
}
    
