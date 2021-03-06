﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ch7Classes
{
    class Point
    {
        private int x, y;

        public Point()
        {
            this.x = -1;
            this.y = -1;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
    }
}
