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
            double counter = getCounter(array);
        }

        // Steps 4. & 5.
        private static double getCounter(Coordinates[] array)
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
