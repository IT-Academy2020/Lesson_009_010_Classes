using System;

// Передача екземпляра класу в якості аргумента методу

namespace Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Виклик методу класа MyClass");
        }
    }

    class MyClass2
    {
        // На 18 рядку створюємо метод з іменем CallMethod, який приймає один аргумент типу MyClass і нічого не повертає
        public void CallMethod(MyClass my)
        {
            // У тілі методу CallMethod, на 21 рядку викликаємо метод з іменем Method аргумента my
            my.Method();
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();

            MyClass2 my2 = new MyClass2();

            my2.CallMethod(my);

            // Затримка
            Console.ReadKey();
        }
    }
}
