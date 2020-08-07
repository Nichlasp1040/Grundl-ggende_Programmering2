using System;

namespace Variabler_og_Datatyper
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////
            //VARIABLE OG DATATYPER//
            ////////////////////////

            int i = 16;

            double j = 5.1;

            //Console.WriteLine(i + j); //Normalt sletter jeg kode jeg ved med sikkerhed jeg ikke kommer til at bruge.

            double c = j + i; //en int er til hele tal og kan derfor ikke complie, hvor double kan klare decimaler.

            Console.WriteLine(c);
        }
    }
}
