using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> iRandList = new List<int>();

            Console.WriteLine("En random liste");
            RandList(iRandList);

            Console.WriteLine("\nListen sorteret");
            BubbleSort(iRandList);

            Console.WriteLine("\nVis den er true so er liste sorteret");
            CheckIfSorted(iRandList);

        }

        public static List<int> BubbleSort(List<int> tmplist)
        {
            int tmp;

            for (int i = 0; i < tmplist.Count; i++)
            {
                for (int j = 0; j < (tmplist.Count - 1) - i; j++)
                {
                    if (tmplist[j] > tmplist[j + 1])
                    {
                        tmp = tmplist[j + 1];
                        tmplist[j + 1] = tmplist[j];
                        tmplist[j] = tmp;
                    }
                }
            }

            for (int i = 0; i < tmplist.Count; i++)
            {
                Console.WriteLine(tmplist[i]);
            }

            return tmplist;
        }

        public static List<int> RandList(List<int> aRandList)
        {
            Random rand = new Random();

            for (int i = 0; i < 7; i++)
            {
                int randNum = rand.Next(1, 199);
                aRandList.Add(randNum);
            }

            for (int i = 0; i < aRandList.Count; i++)
            {
                Console.WriteLine(aRandList[i]);
            }

            return aRandList;
        }

        public static bool CheckIfSorted (List<int> tmplist)
        {
            int tmpCheck = 0;
            bool check;

            for (int i = 0; i < tmplist.Count; i++)
            {
                if (tmplist[i] >= tmplist[i])
                {
                    tmpCheck++;
                }
            }

            if (tmplist.Count == tmpCheck)
            {
                check = true;
            }
            else
            {
                check = false;
            }

            Console.WriteLine(check);

            return check;
        }

    }

}
