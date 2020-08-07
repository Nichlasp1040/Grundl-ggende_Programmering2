using System;

namespace Pytagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////
            //Pytgagoras////
            ////////////////

            Console.Write("tal1:");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("tal2:");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((a * a) + (b * b));

            if (a < b)
            {

                Console.WriteLine("a som er " + a + " er mindre end b som er = " + b);

            }
            else

            {

                Console.WriteLine("b som er = " + b + " er mindre end a som er = " + a);

            }
        }
    }
}
