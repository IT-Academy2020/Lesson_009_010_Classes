using System;

namespace Classes
{
    // Друга частина класу.
    partial class PartialClass
    {
        // Визначення часткового методу. 
        partial void PartialMethod()
        {
            Console.WriteLine("Викликаний частковий метод - PartialMethod ()");
        }

        // Виклик часткового методу через метод обгортку.
        public void CallPartialMethod()
        {
            PartialMethod();

            // Коли Ви викликаєте нереалізований частковий метод, компілятор його проігнорує
            // і помилки рівня виконання не буде. Див. 26 рядок.
            MyMethod();
        }

        #region Реалізація часткових методів в інших частинах класу необов'язкова!

        //partial void MyMethod()
        //{
        //    Console.WriteLine("Реалізація часткових методів в інших частинах класу необов'язкова!"); ;
        //}

        #endregion

    }
}
