using System;

namespace Part1
{
    class Circle : Point
    {
        private double radius;

        public void CalculateArea()
        {
            Console.WriteLine($"Площадь круга равна {Math.PI * Math.Pow(radius, 2)}");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Круг: цвет: {color}, видимость: {(isVisible ? "видимый" : "невидимый")}, координаты: ({x}, {y}), радиус: {radius}");
        }
        public Circle(double Radius, string Color, bool IsVisible) : base(Color, IsVisible)
        {
            radius = Radius;
        }
    }
}
