using System;

// Конструктор може викликати в тому ж самому об'єкті інший конструктор за допомогою ключового слова this.

namespace Classes
{
    class Point
    {
        // Поля.

        private int x, y;
        private string name;

        // Властивості.
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        // Конструктори.

        // Використання ключового слова this в конструкторі з одним параметром з 43-го рядка,
        // призводить до виклику цього конструктора.
        public Point(int x, int y)
        {
            Console.WriteLine("Конструктор з двома параметрами.");
            this.x = x;
            this.y = y;
        }

        // Використання ключового слова this в конструкторі призводить до виклику конструктора з двома параметрами з 35-го рядка.
        public Point(string name) : this(300, 400)
        {
            Console.WriteLine("Конструктор з одним параметром.");
            this.name = name;
        }
    }
}