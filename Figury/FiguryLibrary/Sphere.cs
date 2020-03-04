using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    class Sphere : Circle
    {
        public Sphere(double r = 1) : base(r)
        {
         
        }

        public override string ToString()
        {
            return $"sphere({R})";
        }
    }
}
