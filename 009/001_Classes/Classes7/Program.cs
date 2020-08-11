using System;
using System.Text;

// Конструктори.

// ВАЖЛИВО:
// Якщо ви створили користувацький конструктор (який приймає аргументи),
// то конструктор за замовчуванням, автоматично створюватися НЕ БУДЕ, його доведеться створити явно.

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Застосовуємо конструктор за замовчуванням.

            //Point pointA = new Point();                                              //  Забрати 
            //Console.WriteLine("pointA.X = {0} pointA.Y = {1}", pointA.X, pointA.Y);  //  коментар 

            Console.WriteLine(new string('-', 30));

            // Застосовуємо конструктор з параметрами.

            Point pointB = new Point(100, 200);
            Console.WriteLine("pointB.X = {0} pointB.Y = {1}", pointB.X, pointB.Y);

            // Delay.
            Console.ReadKey();
        }
    }
}
