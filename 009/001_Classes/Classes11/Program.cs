using System;

// Створення екземпляра по слабкому посиланню. (Анонімні об'єкти)

namespace Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Hello world!");
        }
    }

    class Program
    {
        static void Main()
        {
            new MyClass().Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
