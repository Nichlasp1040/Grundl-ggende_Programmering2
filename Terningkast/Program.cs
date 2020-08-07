using System;

namespace Terningkast
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////
            //Terningkast///
            ////////////////

            Random terningKast = new Random();

            int terningsVar = terningKast.Next(1, 6);

            if (terningsVar == 1)

            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("du slog " + terningsVar);

            }

            else if (terningsVar == 2)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("du slog " + terningsVar);

            }
            else if (terningsVar == 3)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("du slog " + terningsVar);

            }
            else if (terningsVar == 4)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("du slog " + terningsVar);

            }
            else if (terningsVar == 5)
            {

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("du slog " + terningsVar);

            }
            else if (terningsVar == 6)
            {

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("du slog " + terningsVar);
            }
            else
            {

                Console.WriteLine("du slog ikke noget");

            }

        }
    }
}
