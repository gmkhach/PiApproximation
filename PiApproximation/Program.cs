using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiApproximation
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates[] array = generateCoordinates();
            int counter = getCounter(array);
            double ratio = getRatio(counter, array);
            printResults(counter, ratio);
        }

        // Step 6.
        private static void printResults(int counter, double ratio)
        {
            Console.WriteLine($"Number of overlaps:\t\t\t{counter}");
            Console.WriteLine($"Pi Approximation:\t\t\t{ratio}");
            Console.WriteLine($"Difference from the actual value of Pi:\t{Math.Abs(Math.PI -ratio)}");
        }

        // Step 5. 
        private static double getRatio(int counter, Coordinates[] array)
        {
            int len = array.Length;
            return 4 * (double)counter/len;
        }

        // Steps 4.
        private static int getCounter(Coordinates[] array)
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

        // Step 3. 
        private static Coordinates[] generateCoordinates()
        {
            Console.WriteLine("\nPlease enter an integer between 10 and 1,000,000");
            int len = int.Parse(Console.ReadLine().Trim());
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

        // Step 2.
        public static double getHypotenus(Coordinates coordinates)
        {
            return Math.Sqrt(Math.Pow(coordinates.getX(), 2) + Math.Pow(coordinates.getY(), 2));
        }
    }
}
