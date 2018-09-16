﻿using System;

namespace PiApproximation
{
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
    }
}
