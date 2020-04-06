using System;

namespace GenesisCinemaChatbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //App info
            string appName = "GenesisCinemaChatbox";
            string appVersion = "1.0.0";
            string appAuthor = "GeoCoder";

            //App details
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine("Welcome to Genesis Cinema");


            //ask for User's name
            Console.WriteLine("What is your name?");

            //Get User's name
            string userName = Console.ReadLine();

            Console.WriteLine("Hey {0}, How can i help you?", userName);
            Console.WriteLine("You want to watch a movie? yes or no");

            //get user option
            string input = Console.ReadLine();

            if (input == "yes")
            {

                //list of movies currently in the cinema
                Console.WriteLine("These are the BLOCKBUSTER movies currently in the Genesis Cinema, enter the number you want to watch");
                Console.WriteLine("1. KING OF BOYS by Kemi Adetiba");
                Console.WriteLine("2. Robinhood");
                Console.WriteLine("3. Chief Daddy");
                Console.WriteLine("4. Lagos Fake LIfestyle");
                Console.WriteLine("5. Acrimony");
                
            }

            else if (input == "no")
            {
                //string option = Console.ReadLine();
                Console.WriteLine("{0}, How can i help you", userName);
            }

            //catch all (incase the user input a non correct option)
            else
            {
                string message = "Enter a correct value";
                Console.WriteLine(message);
            }



            //inputing movie number
                string movieNumber = Console.ReadLine();
                if (movieNumber == "1")
                {
                    string message = "KING OF BOYS, Show Times: 2:30pm - 4:00pm, 4:10pm - 6:00pm, 7:00pm - 9:00pm";
                    Console.WriteLine(message);
                }

                if (movieNumber == "2")
                {
                    string message = ("ROBINHOOD, Show Times: 2:30pm - 4:00pm, 4;10pm - 6:00pm, 7:00pm - 9:00pm");
                    Console.WriteLine(message);
                }

                if (movieNumber == "3")
                {
                    string message = "CHIEF DADDY, Show Times: 2:30pm - 4:00pm, 4:10pm - 6:00pm, 7:00pm - 9:00pm";
                    Console.WriteLine(message);
                }

                if (movieNumber == "4")
                {
                    string message = "LAGOS FAKE LIFESTYLE, Show Times: 2:30pm - 4:00pm, 4:10pm - 6:00pm, 7:00pm - 9:00pm";
                    Console.WriteLine(message);
                }

                if (movieNumber == "5")
                {
                    string message = "ACRIMONY, Show Times: 2:30pm - 4:00pm, 4:10pm - 6:00pm, 7:00pm - 9:00pm";
                    Console.WriteLine(message);
                }

                else
                {
                    string message = "Pls, Enter a real number";
                    Console.WriteLine(message);
                }

           
        }
    }
}
