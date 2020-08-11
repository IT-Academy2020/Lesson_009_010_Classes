using System;

// Автоматично реалізовані властивості (Auto-Implemented properties).

// Автоматично реалізовані властивості це більш зручна форма властивостей, їх є сенс використовувати,
// коли в методах доступу (get і set) не потрібна додаткова логіка.
// При створенні автоматично реалізуваних властивостей, компілятор створить закрите, анонімне резервне поле,
// яке буде доступно за допомогою методів get і set.

namespace Classes
{
    class Program
    {
        public class Author
        {
            // Автоматично реалізовані властивості.
            public string Name { get; set; }
            public string Book { get; set; }
        }

        static void Main()
        {
            Author author1 = new Author()
            {
                Name = "Jeffrey Richter",            // Блок ініціализатора.
                Book = "CLR via C#"
            };

            Author author2 = new Author//()
            {
                Name = "Steve McConnell",            // Блок ініціализатора.
                Book = "Code Complete"
            };

            Console.WriteLine("Name: {0}, Book: {1}", author1.Name, author1.Book);
            Console.WriteLine("Name: {0}, Book: {1}", author2.Name, author2.Book);

            // Delay.
            Console.ReadKey();
        }
    }
}
