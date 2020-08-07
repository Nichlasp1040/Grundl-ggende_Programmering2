using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////
            //Lotto//
            /////////

            int[] lottoKupoon = new int[7];
            int winnerNumber = 0;
            Random rand = new Random();

            for (int i = 0; i < lottoKupoon.Length; i++)
            {
                int genKupoon = rand.Next(1, 20);
                lottoKupoon[i] = genKupoon;
            }

            for (int i = 0; i < lottoKupoon.Length; i++)
            {
                Console.Write(lottoKupoon[i] + " ");

            }

            Console.WriteLine();

            int[] userKupon = { 23, 54, 77, 5, 2, 6, 62 };

            for (int i = 0; i < userKupon.Length; i++)
            {
                Console.Write(userKupon[i] + " ");
            }

            for (int i = 0; i < userKupon.Length; i++)
            {

                if (userKupon[i] == lottoKupoon[i])
                {
                    winnerNumber++;
                }

            }

            switch (winnerNumber)
            {
                case 1:
                    Console.WriteLine("\nDu har vundet 100kr");
                    break;
                case 2:
                    Console.WriteLine("\nDu har vundet 300kr");
                    break;
            }

        }
    }
}
