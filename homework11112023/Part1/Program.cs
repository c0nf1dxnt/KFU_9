using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Task1:\nСоздать интерфейс ICipher и классы ACipher и BCipher с методами, указанными в задании\n");

            string text = "Hello, world!";
            Console.WriteLine($"Исходная строка: {text}");

            ACipher aCipher = new ACipher();
            Console.WriteLine($"Строка зашифрованная классом ACipher: {aCipher.Encode(text)}");
            Console.WriteLine($"Строка дешифрованная классом ACipher: {aCipher.Decode(aCipher.Encode(text))}\n");

            BCipher bCipher = new BCipher();
            Console.WriteLine($"Строка зашифрованная классом BCipher: {bCipher.Encode(text)}");
            Console.WriteLine($"Строка дешифрованная классом BCipher: {bCipher.Decode(bCipher.Encode(text))}\n");
        }
        static void Task2()
        {
            Console.WriteLine("Task2:\nСоздать классы геометрических фигур с методами, указанными в задании\n");

            Point point = new Point("белый", true);
            point.MoveVertically(5);
            point.MoveHorizontally(-2);
            point.PrintInfo();

            Circle circle = new Circle(2, "синий", true);
            circle.MoveVertically(1);
            circle.MoveHorizontally(-6);
            circle.PrintInfo();
            circle.CalculateArea();

            Rectangle rectangle = new Rectangle("красный", false, 0, 0, 5 ,3);
            rectangle.MoveVertically(5);
            rectangle.MoveHorizontally(-6);
            rectangle.PrintInfo();
            rectangle.CalculateArea();
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "Skynet";

            Task1();
            Task2();

            Console.ReadKey();
        }
    }
}
