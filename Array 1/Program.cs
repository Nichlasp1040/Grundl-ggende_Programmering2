using System;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////
            ///Array 1//
            ////////////

            int[] aArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < aArray[4]; i++)
            {
                Console.WriteLine(aArray[i]);
            }
            aArray[4] *= 2;
            Console.WriteLine(aArray[5]);


        }
    }
}
