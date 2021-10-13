using System;
using System.Collections.Generic;

namespace KnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Erin", "Richard", "Cortez", "Cullin", "Anu", "James", "Andy", "Cassly", "Ese", "Huy" };
            
            Dictionary<string, string> HomeTown = new Dictionary<string, string>();
            HomeTown.Add("Erin", "Troy, MI");
            HomeTown.Add("Richard", "Canton, MI");
            HomeTown.Add("Cortez", "Detroit, MI");
            HomeTown.Add("Cullin", "Fowlerville, MI");
            HomeTown.Add("Anu", "Rochester Hills, MI");
            HomeTown.Add("James", "YAP, FSM");
            HomeTown.Add("Andy", "Berkley, MI");
            HomeTown.Add("Cassly", "Detroit, MI");
            HomeTown.Add("Ese", "Detroit, MI");
            HomeTown.Add("Huy", "Lansing, MI");

            Dictionary<string, string> FavFood = new Dictionary<string, string>();
            FavFood.Add("Erin", "Tacos");
            FavFood.Add("Richard", "Sushi");
            FavFood.Add("Cortez", "Chicken Fettuccine");
            FavFood.Add("Cullin", "Pad Thai");
            FavFood.Add("Anu", "Tacos");
            FavFood.Add("James", "Katsu");
            FavFood.Add("Andy", "French Fries");
            FavFood.Add("Cassly", "Steak");
            FavFood.Add("Ese", "Shrimp");
            FavFood.Add("Huy", "Korean BBQ");

            
            bool goOn = true;

            while (goOn == true)
            {
                string student = GetInput("Welcome to GC's DevBuild class! Which student would you like to learn more about? (Enter a number 1-10)");
                int classmate = int.Parse(student);

                if (classmate >= 1 && classmate <= 10)
                {
                    string studentNum = names[classmate];

                    Console.WriteLine($"Student: {studentNum}");
                    Console.WriteLine($"Hometown: {HomeTown[studentNum]}");
                    Console.WriteLine($"Favorite Food: {FavFood[studentNum]}");
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 10");                   
                }
               
                goOn = Continue();
            }
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }

        public static bool RangeCheck(int min, int max, int x)
        {
            
            if (x > min && x <= max)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1-10");
                return false;
            }
        }

        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue? (Y/N)");
            Console.WriteLine();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("See you soon!");
                return false;
            }
            else
            {
                Console.WriteLine("Please Try again");
                Console.WriteLine();
                return Continue();
            }
        }
    }
}
