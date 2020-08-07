using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace Grundlæggende_Programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////
            //VARIABLE OG DATATYPER//
            ////////////////////////

            //int i = 16;

            //double j = 5.1;

            ////Console.WriteLine(i + j); //Normalt sletter jeg kode jeg ved med sikkerhed jeg ikke kommer til at bruge.

            //double c =  j + i; //en int er til hele tal og kan derfor ikke complie, hvor double kan klare decimaler.

            //Console.WriteLine(c);

            ////////////////////
            //Celciusomregner//
            //////////////////

            //Console.WriteLine("Celciusomregner til Reamur & Fahrenheit");

            //double reamur = 0.8;
            //double fahrenheit = 1.8 + 32;

            //Console.Write("Indtast Celcius: ");
            //double i = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(i + " Celcius = " + i * reamur + " Reamur");
            //Console.WriteLine(i + " Celcius = " + i * fahrenheit + " fahrenheit");

            ///////////////////
            //Valutaomregner//
            /////////////////

            //Console.WriteLine("ValutaOmregner");
            //Console.Write("Indtast Dkk: ");
            //decimal userInput = Convert.ToDecimal(Console.ReadLine());

            //decimal usDollars = userInput * 0.16m;
            //decimal britiskePund = userInput * 0.12m;
            //decimal euro = userInput * 0.13m;
            //decimal svenskeKroner = userInput * 1.38m;

            //Console.WriteLine("Danske Kroner i følgende \nUSdollars: " + usDollars);
            //Console.WriteLine("Britiske Pund: " + britiskePund);
            //Console.WriteLine("Euro: " + euro);
            //Console.WriteLine("Svenske Kroner: " + svenskeKroner);

            //////////////
            //Rumfanget//
            ////////////

            //Console.WriteLine("Rumfang beregner");

            //Console.Write("Højde: ");
            //float h = float.Parse(Console.ReadLine());

            //Console.Write("Bredde: ");
            //float b = float.Parse(Console.ReadLine());

            //Console.Write("Længde: ");
            //float l = float.Parse(Console.ReadLine());

            //float v = h * b * l;

            //Console.WriteLine("Rumfanget er: " + v);

            ////////////////
            //Terningkast///
            ////////////////

            //Random terningKast = new Random();

            //int terningsVar = terningKast.Next(1, 6);

            //if (terningsVar == 1)

            //{

            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("du slog " + terningsVar);

            //}

            //else if (terningsVar == 2)
            //{

            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("du slog " + terningsVar);

            //}
            //else if (terningsVar == 3)
            //{

            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.WriteLine("du slog " + terningsVar);

            //}
            //else if (terningsVar == 4)
            //{

            //    Console.ForegroundColor = ConsoleColor.DarkYellow;
            //    Console.WriteLine("du slog " + terningsVar);

            //}
            //else if (terningsVar == 5)
            //{

            //    Console.ForegroundColor = ConsoleColor.DarkBlue;
            //    Console.WriteLine("du slog " + terningsVar);

            //}
            //else if (terningsVar == 6)
            //{

            //    Console.ForegroundColor = ConsoleColor.DarkGray;
            //    Console.WriteLine("du slog " + terningsVar);
            //}
            //else
            //{

            //    Console.WriteLine("du slog ikke noget");

            //}

            ////////////////
            //Pytgagoras////
            ////////////////

            //Console.Write("tal1:");

            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("tal2:");

            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine((a * a) + (b * b));

            //if (a < b)
            //{

            //    Console.WriteLine("a som er " + a + " er mindre end b som er = " + b);

            //}
            //else

            //{

            //    Console.WriteLine("b som er = " + b + " er mindre end a som er = " + a);

            //}

            /////////
            //Alder//
            /////////

            //Console.Write("Indtast dit navn: ");

            //string name = Console.ReadLine();

            //Console.Write("Indtast din alder: ");

            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age < 3)
            //{

            //    Console.WriteLine(name + ", må gå med ble");

            //}
            //else if (age >= 3 && age <= 15)
            //{

            //    Console.WriteLine(name + ", må ingen ting");

            //}
            //else if (age >= 15 && age <= 18)
            //{

            //    Console.WriteLine(name + ", du må drikke");

            //}
            //else if (age > 18)
            //{

            //    Console.WriteLine(name + ", du må stemme og køre bil");

            //}

            //////////////
            //Gæt et tal//
            //////////////

            //Random randNum = new Random();
            //int sikretNum = randNum.Next(1, 30);

            //Console.Write("Gæt et tal: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //int userTrys = 1;

            //while (userInput != sikretNum || sikretNum != userInput)
            //{
            //    if (userInput < sikretNum)
            //    {
            //        Console.Write("Tallet er højre prøv igen: ");
            //        userInput = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (userInput > sikretNum)
            //    {
            //        Console.Write("Tallet er mindre prøv igen: ");
            //        userInput = Convert.ToInt32(Console.ReadLine());
            //    }
            //    userTrys++;
            //}
            //if (userTrys == 1)
            //{
            //    Console.WriteLine("SPOT ON! du gættet korret på " + userTrys + "forsøg!");
            //}
            //else if ( userTrys >= 2)
            //{
            //    Console.WriteLine("Hele " + userTrys + " forsøg det vel ok");
            //}
            //else if (userTrys >= 20)
            //{
            //    Console.WriteLine("Better luck next time det tog dig " + userTrys + " forsøg");
            //}

            /////////
            //Proto//
            /////////

            //string country = null;
            //string _weight = null;
            //int weight = 0;
            //int sizeHeight = 0;
            //int sizeWidth = 0;
            //int sizelength = 0;
            //int proto = 0;
            //string letterOrPackge = null;

            //Console.WriteLine("er det en pakke eller et brev\n1. brev\n2. pakke");
            //letterOrPackge = Console.ReadLine();

            //switch(letterOrPackge)
            //{
            //    case "1":
            //        letterOrPackge = "brev";
            //        break;
            //    case "2":
            //        letterOrPackge = "pakke";
            //        break;
            //}

            //Console.Write("Hvor høj er " + letterOrPackge + ": ");
            //sizeHeight = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Hvor bred er " + letterOrPackge + ": ");
            //sizeWidth = Convert.ToInt32(Console.ReadLine());

            //if (letterOrPackge == "pakke")
            //{
            //    Console.Write("Hvor lang er " + letterOrPackge + ": ");
            //    sizelength = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Hvor maget vejer breavet.\n1. 50g\n2. 100kg\n3. 250g\n4. 500g\n5. 1kg\n6. 2kg");
            //_weight = Console.ReadLine();

            //switch (_weight)
            //{
            //    case "1":
            //        weight = 50;
            //        proto = 10;
            //        break;
            //    case "2":
            //        weight = 100;
            //        proto = 20;
            //        break;
            //    case "3":
            //        weight = 250;
            //        proto = 40;
            //        break;
            //    case "4":
            //        weight = 500;
            //        proto = 60;
            //        break;
            //    case "5":
            //        weight = 1000;
            //        proto = 60;
            //        break;
            //    case "6":
            //        weight = 2000;
            //        proto = 60;
            //        break;
            //}

            //Console.WriteLine("Hvor skal pakken hen?\n1. Danmark\n2. Sverige");
            //country = Console.ReadLine();

            //switch(country)
            //{
            //    case "1":
            //        country = "Danmark";
            //        break;
            //    case "2":
            //        proto += 30;
            //        country = "Sverige";
            //        break;
            //}

            //Console.WriteLine("Det koster: " + proto +
            //    "kr\n" + letterOrPackge + " vejer: " + weight + "g\n" +
            //    letterOrPackge + " størelse er: " + sizeHeight + "cm Høj\n" 
            //    + sizelength + "cm lang\n" + sizeWidth + "cm brad\nog bliver sendt til: " + country);

            ////////////////////
            //Morsekoden - rød//
            ////////////////////

            //Console.Write("Morsekode oversætter fra Alphabet til morsekode \nSkriv noget: ");
            //string userInput = Console.ReadLine();

            //userInput = userInput.ToLower();

            //foreach (char _char in userInput)
            //{
            //    switch (_char)
            //    {
            //        case 'a':
            //            Console.Write(".-");
            //            break;
            //        case 'b':
            //            Console.Write("-...");
            //            break;
            //        case 'c':
            //            Console.Write("-.-.");
            //            break;
            //        case 'd':
            //            Console.Write("-..");
            //            break;
            //        case 'e':
            //            Console.Write(".");
            //            break;
            //        case 'f':
            //            Console.Write("..-");
            //            break;
            //        case 'g':
            //            Console.Write("--.");
            //            break;
            //        case 'h':
            //            Console.Write("....");
            //            break;
            //        case 'i':
            //            Console.Write("..");
            //            break;
            //        case 'j':
            //            Console.Write(".---");
            //            break;
            //        case 'k':
            //            Console.Write("-.-");
            //            break;
            //        case 'l':
            //            Console.Write(".-..");
            //            break;
            //        case 'm':
            //            Console.Write("--");
            //            break;
            //        case 'n':
            //            Console.Write("-.");
            //            break;
            //        case 'o':
            //            Console.Write("---");
            //            break;
            //        case 'p':
            //            Console.Write(".--.");
            //            break;
            //        case 'q':
            //            Console.Write("--.-");
            //            break;
            //        case 'r':
            //            Console.Write(".-.");
            //            break;
            //        case 's':
            //            Console.Write("...");
            //            break;
            //        case 't':
            //            Console.Write("-");
            //            break;
            //        case 'u':
            //            Console.Write("..-");
            //            break;
            //        case 'v':
            //            Console.Write("...-");
            //            break;
            //        case 'w':
            //            Console.Write(".--");
            //            break;
            //        case 'x':
            //            Console.Write("-..-");
            //            break;
            //        case 'y':
            //            Console.Write("-.--");
            //            break;
            //        case 'z':
            //            Console.Write("--..");
            //            break;
            //        case 'æ':
            //            Console.Write(".-.-");
            //            break;
            //        case 'ø':
            //            Console.Write("---.");
            //            break;
            //        case 'å':
            //            Console.Write(".--.-");
            //            break;
            //    }
            //}

            ////////////////////
            //igang med løkker//
            ////////////////////

            ////int i = 0;
            ////while (i < 99)
            //for (int i = 100; i > 0; i--)
            //{
            //    if (i <= 99)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    //i--;
            //}

            ////////////
            ///Array 1//
            ////////////

            //int[] aArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //for (int i = 0; i < aArray[4]; i++)
            //{
            //    Console.WriteLine(aArray[i]);
            //}
            //aArray[4] *= 2;
            //Console.WriteLine(aArray[5]);

            //////////
            //Arrays//
            //////////

            //Øvelse 1

            //string userInputUsername = null;
            //string userInputPassword = null;

            //bool usernameC = true;
            //bool a = true;
            //int i = 0;

            //string[] userName = {
            //"username1",
            //"username2",
            //"username3",
            //"username4",
            //"username5",
            //};
            //string[] passWord = {
            //"password1",
            //"password2",
            //"password3",
            //"password4",
            //"password5",
            //};

            //do
            //{

            //    Console.Write("Username: ");
            //    userInputUsername = Console.ReadLine();

            //    for (i = 0; i < userName.Length; i++)
            //    {

            //        if (userInputUsername == userName[i])
            //        {
            //            Console.Write("Password: ");
            //            userInputPassword = Console.ReadLine();

            //            usernameC = false;

            //            if (userInputPassword == passWord[i])
            //            {
            //                Console.WriteLine("Du er logget ind");
            //                a = false;
            //            }
            //            else if (userInputPassword != passWord[i])
            //            {
            //                for (int j = 3; j > 1; j--)
            //                {
            //                    Console.Write("Forkert kode du har " + j + " forsøg tilbage\nPassword: ");
            //                    userInputPassword = Console.ReadLine();
            //                    if (userInputPassword == passWord[i])
            //                    {
            //                        Console.WriteLine("Du er logget ind");
            //                        j = 0;
            //                        a = false;
            //                    }
            //                    else if (j == 3)
            //                    {
            //                        Console.WriteLine("Du har ikke flere forsøg");
            //                        a = false;
            //                    }

            //                }

            //            }
            //        }

            //    }
            //    if (usernameC == true)
            //    {
            //        Console.WriteLine("Brugeren findes ikke\n");
            //    }

            //} while (a == true);

            //Øvelse 2

            //string searchNames = null;
            //string selectOption = null;

            //bool a = true;

            //string[] namesArray =
            //{
            //    "William", "Oliver", "Noah", "Emil",
            //    "Victor", "Magnus", "Frederik", "Mikkel",
            //    "Lucas", "Alexander", "Oscar", "Mathias",
            //    "Sebastian", "Malthe", "Elias", "Christian",
            //    "Malthe", "Eilas", "Gustav", "Nichlas",
            //};

            //Console.WriteLine("Name search.\n1. for at søge et navn\n2. for at få vist hele listen");
            //selectOption = Console.ReadLine();

            //if (selectOption == "1")
            //{
            //    do
            //    {
            //        Console.Write("Søg navn: ");
            //        searchNames = Console.ReadLine();

            //        for (int i = 0; i < namesArray.Length; i++)
            //        {
            //            if (namesArray[i].ToLower().Contains(searchNames))
            //            {
            //                Console.WriteLine(namesArray[i]);
            //                a = false;
            //            }

            //        }


            //    } while (a == true);

            //}

            //if (selectOption == "2")
            //{
            //    Array.Sort(namesArray);
            //    for (int i = 0; i < namesArray.Length; i++)
            //    {
            //        Console.WriteLine(namesArray[i]);
            //    }

            //}

            //Øvelse 3

            //string searchNames = null;
            //string selectOption = null;

            //bool a = true;

            //string[] boyNames =
            //{
            //    "William", "Oliver", "Noah", "Emil",
            //    "Victor", "Magnus", "Frederik", "Mikkel",
            //    "Lucas", "Alexander", "Oscar", "Mathias",
            //    "Sebastian", "Malthe", "Elias", "Christian",
            //    "Malthe", "Eilas", "Gustav", "Nichlas",
            //};
            //string[] girlNames =
            //{

            //};

            //ArrayList arList = new ArrayList();
            //arList.AddRange(boyNames);

            //do
            //{
            //    Console.WriteLine("Name search.\n" +
            //        "1. for at søge et navn\n" +
            //        "3. for at få vist hele listen\n" +
            //        "6. Exit");
            //    selectOption = Console.ReadLine();

            //    switch (selectOption)
            //    {
            //        case "1":
            //            Console.Write("Søg navn: ");
            //            searchNames = Console.ReadLine();

            //            for (int i = 0; i < arList.Count; i++)
            //            {
            //                if (boyNames[i].ToLower().Contains(searchNames))
            //                {
            //                    Console.WriteLine(boyNames[i]);
            //                    a = false;
            //                }

            //            }
            //            break;

            //        case "2":
            //            for (int i = 0; i < arList.Count; i++)
            //            {
            //                if (girlNames[i].ToLower().Contains(searchNames))
            //                {
            //                    Console.WriteLine(girlNames[i]);
            //                    a = false;
            //                }

            //            }
            //            break;

            //        case "3":
            //            arList.Sort();
            //            for (int i = 0; i < arList.Count; i++)
            //            {
            //                Console.WriteLine(arList[i]);
            //            }
            //            break;

            //        case "4":

            //            break;

            //        case "5":

            //            break;

            //        case "6":
            //            a = false;
            //            break;
            //    }


            //} while (a == true);

            ///////////////////////
            //Arrays og bubblesort/
            ///////////////////////

            //int[] numbers = new int[100];
            //int[] numbersRe = numbers;
            //Random rand = new Random();
            //int temp;

            //for (int i = 0; i < 100; i++)
            //{
            //    int randNumbers = rand.Next(1, 300);
            //    numbers[i] = randNumbers;
            //}

            //for (int j = 0; j <= numbers.Length - 2; j++)
            //{
            //    for (int i = 0; i <= numbers.Length - 2; i++)
            //    {
            //        if (numbers[i] > numbers[i + 1])
            //        {
            //            temp = numbers[i + 1];
            //            numbers[i + 1] = numbers[i];
            //            numbers[i] = temp;
            //        }
            //    }
            //}
            //Array.Reverse(numbersRe);
            //for (int i = 0; i < numbersRe.Length; i++)
            //{
            //    Console.WriteLine(numbersRe[i]);
            //}

            /////////
            //Liste//
            /////////

            //List<int> listB = new List<int>();

            //Console.WriteLine("Fuld liste.");
            //Liste.FullList(listB);

            //Console.WriteLine("\nAlle lige tal.");
            //Liste.InSecend(listB);

            //Console.WriteLine("\nAlle lige tal, uden dem der går op i 3.");
            //Liste.InThird(listB);


            //int j = 2;
            //int i;

            //for (i = 0; i < listB.Count; i++)
            //{
            //    if (listB[i] % 2 == 0)
            //    {
            //        if (listB[i] % 3 == 0)
            //        {
            //            Console.WriteLine(listB[i]);
            //        }

            //    }
            //}

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
