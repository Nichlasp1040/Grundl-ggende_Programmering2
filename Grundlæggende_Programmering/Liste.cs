using System;
using System.Collections.Generic;
using System.Text;

namespace Grundlæggende_Programmering
{
    class Liste
    {
        public static List<int> FullList(List<int> tempList)
        {
            for (int i = 0; i < 20; i++)
            {
                tempList.Add(i + 1);
                Console.WriteLine(tempList[i]);
            }
            return tempList;
        }

        public static List<int> InSecend(List<int> tempList)
        {
            for (int i = 0; i < 20; i++)
            {
                tempList.Add(i + 1);
                if (tempList[i] % 2 == 0)
                {
                    Console.WriteLine(tempList[i]);
                }

            }
            return tempList;
        }

        public static List<int> InThird(List<int> tempList)
        {
            for (int i = 0; i < 20; i++)
            {
                tempList.Add(i + 1);
                if (tempList[i] % 2 == 0)
                {
                    if (tempList[i] % 3 != 0)
                    {
                        Console.WriteLine(tempList[i]);
                    }
                }

            }
            return tempList;
        }

    }
}
