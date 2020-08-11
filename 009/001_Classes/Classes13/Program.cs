using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {           
            Document document = new Document("Контракт");
            document.Body = "Тіло контракта...";
            document.Footer = "Директор: Іванов І.І.";

            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
