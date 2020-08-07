using System;

namespace ValutaOmregner
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////
            //Valutaomregner//
            /////////////////

            Console.WriteLine("ValutaOmregner");
            Console.Write("Indtast Dkk: ");
            decimal userInput = Convert.ToDecimal(Console.ReadLine());

            decimal usDollars = userInput * 0.16m;
            decimal britiskePund = userInput * 0.12m;
            decimal euro = userInput * 0.13m;
            decimal svenskeKroner = userInput * 1.38m;

            Console.WriteLine("Danske Kroner i følgende \nUSdollars: " + usDollars);
            Console.WriteLine("Britiske Pund: " + britiskePund);
            Console.WriteLine("Euro: " + euro);
            Console.WriteLine("Svenske Kroner: " + svenskeKroner);

        }
    }
}
