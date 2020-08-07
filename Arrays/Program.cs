using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}
