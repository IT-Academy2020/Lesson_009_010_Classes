using System;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Title title = new Title();
            title.Content = "Контракт";

            Body body = new Body();
            body.Content = "Тіло контракта...";

            Footer footer = new Footer();
            footer.Content = "Директор: Іванов І.І.";

            Document document = new Document(title, body, footer);
            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
