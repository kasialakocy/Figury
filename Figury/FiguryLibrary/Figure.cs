using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Figure
    {

        public string Color { get; private set; } //read only
        public Figure (string color = "black")
        {
            Color = color;

        }

        public void Print()
        {
            Console.WriteLine($"figure {this}, color = {Color}");

        }
        abstract public void Draw(); // rysowanie figury za pomoca plottera
    }
}
