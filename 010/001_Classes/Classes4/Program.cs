using System;
using System.Text;

// readonly - поля тільки для читання.

namespace Classes
{
    class Program
    {
        // Поле тільки для читання (встановлюється тільки конструктором)!

        public readonly string field = "hello";

        // Конструктор.

        public Program()
        {
            field = "Поле тільки для читання ";

            field += "!";
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Program program = new Program();

            Console.WriteLine(program.field);

            // Помилка Компіляція.
            //program.field = "Спроба запису в поле тільки для читання.";

            // Delay.
            Console.ReadKey();
        }
    }
}
