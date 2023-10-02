using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Figure
    {
        private Point[] points;

        public Figure(Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
            {
                throw new ArgumentException("The number of points should be from 3 to 5");
            }

            this.points = points;
        }

        public double GetSideLength(Point A, Point B)
        {
            double deltaX = B.X - A.X;
            double deltaY = B.Y - A.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length; i++)
            {
                int nextIndex = (i + 1) % points.Length;
                double sideLength = GetSideLength(points[i], points[nextIndex]);
                perimeter += sideLength;
            }

            Console.WriteLine($"Perimeter of polygon: {perimeter}");
        }
    }
}