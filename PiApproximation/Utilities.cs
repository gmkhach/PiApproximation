using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiApproximation
{
    class Utilities
    {
        // Step 2.
        public static double getHypotenus(Coordinates coordinates)
        {
            return Math.Sqrt(Math.Pow(coordinates.getX(), 2) + Math.Pow(coordinates.getY(), 2));
        }

        // Step 3. 
        public static int getLength()
        {
            Console.Write("\nPlease enter an integer between 10 and 1,000,000 to indicates the number of points in your sample\n\n>>> ");
            return int.Parse(Console.ReadLine().Trim());
        }

        // Step 3. continued
        public static Coordinates[] generateCoordinates(int len)
        {
            Random rnd = new Random();
            Coordinates[] array = new Coordinates[len];
            for (int i = 0; i < len; i++)
            {
                double x = rnd.NextDouble();
                double y = rnd.NextDouble();
                array[i] = new Coordinates(x, y);
            }
            return array;
        }

        // Steps 4.
        public static int getCounter(Coordinates[] array)
        {
            int counter = 0;
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                if (getHypotenus(array[i]) <= 1)
                {
                    counter++;
                }
            }
            return counter;
        }

        // Step 5. 
        public static double getRatio(int counter, int len)
        {
            return 4 * (double)counter / len;
        }
        
        // Step 6.
        public static void printResults(int counter, double ratio)
        {
            Console.WriteLine($"\nNumber of overlaps:\t\t\t{counter}");
            Console.WriteLine($"Pi Approximation:\t\t\t{ratio}");
            Console.WriteLine($"Difference from the actual value of Pi:\t{Math.Abs(Math.PI - ratio)}");
        }

        // Step 7.
        public static void runPresets()
        {
            int[] runs = { 10, 100, 1000, 10000 };
            Console.WriteLine("\nHere are the Pi approximation results for running the simulation for 10, 100, 1000, and 10000 points.");
            foreach (int number in runs)
            {
                Console.WriteLine($"\n{number} points:");
                Program.runSimulation(number);
            }
        }
    }
}
