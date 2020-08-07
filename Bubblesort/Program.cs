using System;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////
            //Arrays og bubblesort/
            ///////////////////////

            int[] numbers = new int[100];
            int[] numbersRe = numbers;
            Random rand = new Random();
            int temp;

            for (int i = 0; i < 100; i++)
            {
                int randNumbers = rand.Next(1, 300);
                numbers[i] = randNumbers;
            }

            for (int j = 0; j <= numbers.Length - 2; j++)
            {
                for (int i = 0; i <= numbers.Length - 2; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            Array.Reverse(numbersRe);
            for (int i = 0; i < numbersRe.Length; i++)
            {
                Console.WriteLine(numbersRe[i]);
            }

        }
    }
}
