using System;

namespace Classes
{
    class Point
    {
        // Поля.
        private int x, y;

        // Властивості.
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        // Конструктор за замовчуванням, ініціалізує поля значеннями за замовчуванням.
        public Point()
        {
            Console.WriteLine("Конструктор за замовчуванням!");
        }

        // Користувацький конструктор, ініціалізує поля значеннями заданими користувачем.
        public Point(int x, int y)
        {
            Console.WriteLine("Користувацький конструктор!");
            this.x = x;
            this.y = y;
        }
    }
}