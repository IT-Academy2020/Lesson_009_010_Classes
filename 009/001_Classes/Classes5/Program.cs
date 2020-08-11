using System;

// Класи.
// Властивості з одним методом доступу.

namespace Classes
{
    class Constants
    {
        private double pi = 3.14D;
        private double e = 2.71D;

        // Властивість тільки для запису. - WriteOnly Property
        public double Pi
        {
            set { pi = value; }
        }

        // Властивість тільки для читання. - ReadOnly Property
        public double E
        {
            get { return e; }
        }
    }

    class Program
    {
        static void Main()
        {
            Constants constants = new Constants();

            constants.Pi = 3.14159265D;
            //Console.WriteLine(constants.Pi); // Недопустимо.

            //constants.E = 3.71D;             // Недопустимо.
            Console.WriteLine("e = {0}", constants.E);

            // Delay.
            Console.ReadKey();
        }
    }
}
