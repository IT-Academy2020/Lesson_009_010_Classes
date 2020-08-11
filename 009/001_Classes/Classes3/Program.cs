using System;

// Класи. (Використання властивостей, для доступу до закритих полів.)

// Властивість - це інтерфейс взаємодії з полем об'єкта.
// Властивості в C# - це поля з блоком коду, в якому є ключові слова get і set, які заміняють методи доступу до поля.
// При зверненні до властивості викликається певний метод, який виконує певні операції з об'єктом.

namespace Classes
{
    class MyClass
    {
        private string field = null;

        public string Field
        {
            set  // void SetField(string value)   -    Метод-мутатор - mutator   (setter)
            {
                field = value;               
            }

            get  // string GetField()             -    Метод-аксессор - accessor (getter)
            {
                return field;                 
            }            
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            instance.Field = "Hello world!";    // Метод-мутатор

            Console.WriteLine(instance.Field);  // Метод-аксессор

            // Delay.
            Console.ReadKey();
        }
    }
}
