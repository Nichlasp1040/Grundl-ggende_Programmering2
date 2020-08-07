using System;

namespace Rumfanget
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////
            //Rumfanget//
            ////////////

            Console.WriteLine("Rumfang beregner");

            Console.Write("Højde: ");
            float h = float.Parse(Console.ReadLine());

            Console.Write("Bredde: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Længde: ");
            float l = float.Parse(Console.ReadLine());

            float v = h * b * l;

            Console.WriteLine("Rumfanget er: " + v);

        }
    }
}
