using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Circle : Figure
    {
        public double R { get; private set; }
        public Circle(double r = 1)
        {
            if (r <= 0)
                throw new ArgumentOutOfRangeException("promień musi byc dodatni");

            R = r;

        }

        public double Perimeter => 2 * Math.PI * R;

        public double Surface => 2 * Math.PI * R;

        public Circle Scale(double factor)
        {

            if (factor <= 0)
                throw new ArgumentOutOfRangeException("współ musi być dodatni");

            return new Circle(R * factor);
        }

        public override string ToString()
        {
            return $"circle({R})";
        }


    }
}
