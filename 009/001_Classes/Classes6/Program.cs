using System;
using System.Text;

// Конструктори.

namespace Classes
{
    class Program
    {       
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Використовуємо конструктор за замовчуванням.

            Point pointA = new Point();
            Console.WriteLine("pointA.X = {0} pointA.Y = {1}", pointA.X, pointA.Y);

            Console.WriteLine(new string('-', 30));

            // Використовуємо конструктор з параметрами.

            Point pointB = new Point(100, 200);
            Console.WriteLine("pointB.X = {0} pointB.Y = {1}", pointB.X, pointB.Y);

            // Delay.
            Console.ReadKey();
        }
    }
}
