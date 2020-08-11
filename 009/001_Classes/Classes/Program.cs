using System;

// Класи.

namespace Classes
{
    // Створюємо клас з іменем MyClass.
    // У тілі класу створюємо відкрите поле типу string з іменем field і метод з іменем Method.

    class MyClass
    {
        public string field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main()
        {
            // 1. Створюємо екземпляр класу MyClass (по сильному посиланню).
            // 2. Створюємо екземпляр класу MyClass з іменем instance.
            // 3. Інстанціюємо клас MyClass.
            // 4. Створюємо змінну з іменем instance, типу MyClass і присвоюємо їй адресу екземпляра на кучі.
            // (instance - є посиланням на екземпляр класу MyClass побудований на кучі)

            MyClass instance = new MyClass();

            // Полю field, екземпляра instance, присвоюємо значення Hello world!

            instance.field = "Hello world!";

            // Виводимо на екран значення поля field екземпляра instance.

            Console.WriteLine(instance.field);

            // Виклик методу з іменем Method на екземплярі instance.

            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
