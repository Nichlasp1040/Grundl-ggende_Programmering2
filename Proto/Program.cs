using System;

namespace Proto
{
    class Program
    {
        static void Main(string[] args)
        {

            /////////
            //Proto//
            /////////

            string country = null;
            string _weight = null;
            int weight = 0;
            int sizeHeight = 0;
            int sizeWidth = 0;
            int sizelength = 0;
            int proto = 0;
            string letterOrPackge = null;

            Console.WriteLine("er det en pakke eller et brev\n1. brev\n2. pakke");
            letterOrPackge = Console.ReadLine();

            switch (letterOrPackge)
            {
                case "1":
                    letterOrPackge = "brev";
                    break;
                case "2":
                    letterOrPackge = "pakke";
                    break;
            }

            Console.Write("Hvor høj er " + letterOrPackge + ": ");
            sizeHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hvor bred er " + letterOrPackge + ": ");
            sizeWidth = Convert.ToInt32(Console.ReadLine());

            if (letterOrPackge == "pakke")
            {
                Console.Write("Hvor lang er " + letterOrPackge + ": ");
                sizelength = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Hvor maget vejer breavet.\n1. 50g\n2. 100kg\n3. 250g\n4. 500g\n5. 1kg\n6. 2kg");
            _weight = Console.ReadLine();

            switch (_weight)
            {
                case "1":
                    weight = 50;
                    proto = 10;
                    break;
                case "2":
                    weight = 100;
                    proto = 20;
                    break;
                case "3":
                    weight = 250;
                    proto = 40;
                    break;
                case "4":
                    weight = 500;
                    proto = 60;
                    break;
                case "5":
                    weight = 1000;
                    proto = 60;
                    break;
                case "6":
                    weight = 2000;
                    proto = 60;
                    break;
            }

            Console.WriteLine("Hvor skal pakken hen?\n1. Danmark\n2. Sverige");
            country = Console.ReadLine();

            switch (country)
            {
                case "1":
                    country = "Danmark";
                    break;
                case "2":
                    proto += 30;
                    country = "Sverige";
                    break;
            }

            Console.WriteLine("Det koster: " + proto +
                "kr\n" + letterOrPackge + " vejer: " + weight + "g\n" +
                letterOrPackge + " størelse er: " + sizeHeight + "cm Høj\n"
                + sizelength + "cm lang\n" + sizeWidth + "cm brad\nog bliver sendt til: " + country);

        }
    }
}
