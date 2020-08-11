using System;
using System.Text;

// Класи.
// Використання властивостей, для доступу до закритих полів.

namespace Classes
{
    class MyClass
    {
        private string field = null;

        public string Field
        {
            set
            {
                if (value == "Goodbye")
                    Console.WriteLine("Ви ввели недійсне значення. Повторіть спробу.");
                else
                    field = value;
            }

            get
            {
                if (field == null)
                    return "В полі field відсутні дані.";
                else if (field == "hello world")
                    return field.ToUpper() + "!";
                else
                    return field;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            MyClass instance = new MyClass();

            instance.Field = "Goodbye";
            Console.WriteLine(instance.Field);

            Console.WriteLine(new string('-', 50));

            instance.Field = "hello world";
            Console.WriteLine(instance.Field);

            // Delay.
            Console.ReadKey();
        }
    }
}
