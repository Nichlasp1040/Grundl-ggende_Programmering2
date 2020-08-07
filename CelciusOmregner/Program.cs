using System;

namespace CelciusOmregner
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////
            //Celciusomregner//
            //////////////////

            Console.WriteLine("Celciusomregner til Reamur & Fahrenheit");

            double reamur = 0.8;
            double fahrenheit = 1.8 + 32;

            Console.Write("Indtast Celcius: ");
            double i = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(i + " Celcius = " + i * reamur + " Reamur");
            Console.WriteLine(i + " Celcius = " + i * fahrenheit + " fahrenheit");
        }
    }
}
