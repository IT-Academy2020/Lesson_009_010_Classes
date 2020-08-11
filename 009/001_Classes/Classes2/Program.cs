using System;

// Класи.
// Використання методів доступу до закритих полів.

namespace Classes
{
    class MyClass
    {
        private string field = null;

        public void SetField(string value) // Метод-мутатор   - mutator  (setter)
        {
            field = value;
        }

        public string GetField()           // Метод-аксессор -  accessor (getter)
        {
            return field;
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            instance.SetField("Hello world!");     // Метод-мутатор

            string @string = instance.GetField();  // Метод-аксессор

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
