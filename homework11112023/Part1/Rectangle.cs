using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Rectangle : Point
    {
        protected double length;
        protected double width;

        public Rectangle(string Color, bool IsVisible, double X, double Y, double Width, double Length) : base(Color, IsVisible)
        {
            length = Length;
            width = Width;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Прямоугольник: цвет: {color}, видимость: {(isVisible ? "видимый" : "невидимый")}, координаты: ({x}, {y}), стороны: {length}x{width}");
        }

        public void CalculateArea()
        {
            Console.WriteLine($"Площадь прямоугольника равна: {length * width}");
        }

    }
}
