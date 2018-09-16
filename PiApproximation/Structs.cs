using System;

namespace PiApproximation
{
    // Step 1. 
    class Coordinates
    {
        public Coordinates(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Coordinates(Random rnd)
        {
            this.x = rnd.NextDouble();
            this.y = rnd.NextDouble();
        }

        double x;
        double y;

        public double getX() => x;
        public double getY() => y;
    }
}
