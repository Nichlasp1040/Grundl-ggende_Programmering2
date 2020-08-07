using System;

namespace Alder
{
    class Program
    {
        static void Main(string[] args)
        {

            /////////
            //Alder//
            /////////

            Console.Write("Indtast dit navn: ");

            string name = Console.ReadLine();

            Console.Write("Indtast din alder: ");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 3)
            {

                Console.WriteLine(name + ", må gå med ble");

            }
            else if (age >= 3 && age <= 15)
            {

                Console.WriteLine(name + ", må ingen ting");

            }
            else if (age >= 15 && age <= 18)
            {

                Console.WriteLine(name + ", du må drikke");

            }
            else if (age > 18)
            {

                Console.WriteLine(name + ", du må stemme og køre bil");

            }

        }
    }
}
