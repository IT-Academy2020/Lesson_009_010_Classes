using System;

// Самоасоціації (self-association).

namespace Classes
{
    class MyClass
    {
        MyClass instance;

        public MyClass()  // StackOverflowException
        {
            Console.WriteLine("Constructor MyClass");

            // Самоасоціації, після першої спроби інстанціювати призводить до циклічності інстанціювання.

            instance = new MyClass();
        }
    }

    class Program
    {
        static void Main()
        {
            // Спроба інстанціювання класу MyClass.

            MyClass instance = new MyClass();

            // Delay.
            Console.ReadKey();
        }
    }
}
