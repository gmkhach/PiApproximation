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
            double[,] array = generateCoordinates();
        }

        private static double[,] generateCoordinates()
        {
            Console.WriteLine("\nPlease enter an integer between 10 and 1,000,000");
            int len = int.Parse(Console.ReadLine().Trim());
            Random rnd = new Random();
            double[,] array = new double[len, 2];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array[i, j] = rnd.NextDouble();
                }
            }
            return array;
        }

        public static double getHypotenus(Coordinates coordinates)
        {
            return Math.Sqrt(Math.Pow(coordinates.getX(), 2) + Math.Pow(coordinates.getY(), 2));
        }
    }
}
