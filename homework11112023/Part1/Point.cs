using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Point : Figure
    {
        public override void PrintVisibility()
        {
            Console.WriteLine(isVisible ? "Точка видима" : "Точка невидима");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Точка: цвет: {color}, видимость: {(isVisible ? "видимая" : "невидимая")}, координаты: ({x}, {y})");
        }
        public Point(string Color, bool IsVisible) : base(Color, IsVisible) { }
    }
}
