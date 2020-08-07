using System;

namespace Gæt_et_tal
{
    class Program
    {
        static void Main(string[] args)
        {

            //////////////
            //Gæt et tal//
            //////////////

            Random randNum = new Random();
            int sikretNum = randNum.Next(1, 30);

            Console.Write("Gæt et tal: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int userTrys = 1;

            while (userInput != sikretNum || sikretNum != userInput)
            {
                if (userInput < sikretNum)
                {
                    Console.Write("Tallet er højre prøv igen: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else if (userInput > sikretNum)
                {
                    Console.Write("Tallet er mindre prøv igen: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                userTrys++;
            }
            if (userTrys == 1)
            {
                Console.WriteLine("SPOT ON! du gættet korret på " + userTrys + "forsøg!");
            }
            else if (userTrys >= 2)
            {
                Console.WriteLine("Hele " + userTrys + " forsøg det vel ok");
            }
            else if (userTrys >= 20)
            {
                Console.WriteLine("Better luck next time det tog dig " + userTrys + " forsøg");
            }
        }
    }
}
