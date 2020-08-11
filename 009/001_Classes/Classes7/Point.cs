﻿using System;

// ВАЖЛИВО:
// Якщо ви створили користувацький конструктор (який приймає аргументи),
// то конструктор за замовчуванням, автоматично створюватися НЕ БУДЕ, його доведеться створити явно.

namespace Classes
{
    class Point
    {
        // Поля.
        private int x, y;

        // Властивості.
        public int Y
        {
            get { return y; }
        }

        public int X
        {
            get { return x; }
        }

        // Конструктор за замовчуванням, ініціалізує поля значеннями за замовчуванням.

        //public Point()
        //{
        //    Console.WriteLine("Конструктор за замовчуванням!");
        //}

        // Користувацький конструктор, ініціалізує поля значеннями заданими користувачем.

        public Point(int x, int y)
        {
            Console.WriteLine("Користувацький конструктор!");
            this.x = x;
            this.y = y;
        }
    }
}