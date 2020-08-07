using System;
using System.Collections.Generic;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////
            //Liste//
            /////////

            List<int> listB = new List<int>();

            Console.WriteLine("Fuld liste.");
            Liste.FullList(listB);

            Console.WriteLine("\nAlle lige tal.");
            Liste.InSecend(listB);

            Console.WriteLine("\nAlle lige tal, uden dem der går op i 3.");
            Liste.InThird(listB);


            int j = 2;
            int i;

            for (i = 0; i < listB.Count; i++)
            {
                if (listB[i] % 2 == 0)
                {
                    if (listB[i] % 3 == 0)
                    {
                        Console.WriteLine(listB[i]);
                    }

                }
            }
        }
    }
}
