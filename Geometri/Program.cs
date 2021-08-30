using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int numGenFirst = rand.Next(3, 10);
                int numGenSecond = rand.Next(0, 9);
                float numGenConcat = (float)numGenFirst + ((float)numGenSecond / 10);
                Square tempBox = new Square(numGenConcat);
                Console.WriteLine("Before:");
                Console.WriteLine($"Box {i + 1} Side: {tempBox.Side}");
                Console.WriteLine($"Box {i+1} Perimeter: {tempBox.Perimeter()}");
                Console.WriteLine($"Box {i+1} Area: {tempBox.Area()}");
                Console.WriteLine();
                Console.WriteLine("After:");
                tempBox.Side += rand.Next(-2, 5);
                Console.WriteLine($"Box {i + 1} Side: {tempBox.Side}");
                Console.WriteLine($"Box {i + 1} Perimeter: {tempBox.Perimeter()}");
                Console.WriteLine($"Box {i + 1} Area: {tempBox.Area()}");
                Console.WriteLine("\n\n");
            }


            Console.ReadKey();
        }
    }
}
