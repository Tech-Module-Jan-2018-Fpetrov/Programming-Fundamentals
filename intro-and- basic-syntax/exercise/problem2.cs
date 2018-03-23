using System;

namespace _02.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
			// We have to read WIDTH from Console.
            var width = float.Parse(Console.ReadLine());
			// We have to read HEIGHT from Console.
            var height = float.Parse(Console.ReadLine());
			
			// We create new VAR with name SUM. Now we have to multiply WIDTH and HEIGHT.
            var sum = width * height;
			
			// Print the result of SUM.
            Console.WriteLine($"{sum:F2}");
        }
    }
}