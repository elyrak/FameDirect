using BLogic;
using DL;
using TheModel;
using System;
using System.IO;

namespace FameDirect
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("                                            Please Select Your Account");
            Console.WriteLine("                  ---------------------------------------------------------------------------");
            Console.WriteLine("Your User Accounts: ");
            Console.WriteLine();
            Console.WriteLine("[Anne]       [Irene]       [Yoko]");
            Console.WriteLine();
            Console.WriteLine("Enter UserName: ");
            string userName = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            DirectorGetServices verify = new DirectorGetServices();
            bool result = verify.verifyUser(userName, password);




            if (result)
            {
                DirectorData directList = new DirectorData();

                Console.WriteLine("                                            Welcome User!");
                Console.WriteLine("                   --------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please Choose Your Favorite Director:");
                Console.WriteLine();


                while (true)
                {
                    Console.WriteLine("1. Greta Gerwig");
                    Console.WriteLine();
                    Console.WriteLine("2. Christopher Nolan");
                    Console.WriteLine();
                    Console.WriteLine("3. Daniel Kwan");
                    Console.WriteLine();
                    Console.WriteLine("4. Steven Spielberg");
                    Console.WriteLine();
                    Console.WriteLine("5. Woody Allen");
                    Console.WriteLine();
                    Console.WriteLine("6. Amy Heckerling");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    string choice = Console.ReadLine();

                    Directors selectedDirector = null;

                    switch (choice)
                    {
                        case "1":
                            selectedDirector = directList.GetDirectors()[0];
                            break;

                        case "2":
                            selectedDirector = directList.GetDirectors()[1];
                            break;

                        case "3":
                            selectedDirector = directList.GetDirectors()[2];
                            break;

                        case "4":
                            selectedDirector = directList.GetDirectors()[3];
                            break;

                        case "5":
                            selectedDirector = directList.GetDirectors()[4];
                            break;

                        case "6":
                            selectedDirector = directList.GetDirectors()[5];
                            break;


                        default:
                            Console.WriteLine("Invalid Input.");
                            Console.WriteLine();
                            Console.WriteLine("-------------------");
                            break;
                    }

                    if (selectedDirector != null)
                    {
                        DisplayDirectorsInfo(selectedDirector);
                    }
                    else
                    {
                        Console.WriteLine("Director not found.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error...");
            }
        }

        private static void DisplayDirectorsInfo(Directors director)
        {
            Console.WriteLine(" Name: " + director.director);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" Movies Directed:" + director.moviesName);
            Console.WriteLine();
            Console.WriteLine(" TV Series Name: " + director.tvSeriesName);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
