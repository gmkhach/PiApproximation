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

        }

        public static double getHypotenus(Coordinates coordinates)
        {
            return Math.Sqrt(Math.Pow(coordinates.getX(), 2) + Math.Pow(coordinates.getY(), 2));
        }
    }
}
