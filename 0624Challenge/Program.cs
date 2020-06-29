using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0624Challenge
{
    enum RestaurantNames{RedRobin, BruBurger, Ralstons, Bakersfield}

    class Program
    {
        static void Main(string[] args)
        {

    //Types
            // Value Types 
            string firstName;
            string LastName; 
            double tipAmount = 39.33d;
            char character = 'a';
            int numberOfStores = 3;
            bool isDelicious = true;

            RestaurantNames favRestaurant = RestaurantNames.Ralstons;
            Console.WriteLine(tipAmount);
            Console.WriteLine(character);
            Console.WriteLine(numberOfStores);
            Console.WriteLine(favRestaurant);
            Console.WriteLine(isDelicious);

            // Reference Types 
                // composite
                string welcome = "Welcome to Amazon!";
                string spamMessage = "This is spam!!!!!!32l4lk32j4l3k2j";
                string color = "gold";
                string welcomeMessage = string.Format("Congratulations on being a {0} member. You have been {0} since 1990.", color);

                Console.WriteLine(welcome);
                Console.WriteLine(spamMessage);
                Console.WriteLine(welcomeMessage);

                // interpolation
                string cheese = "string cheese";
                string pasta = "mac and cheese";
                string beans = "kidney beans";
                string randomSentence = $"The stringiest cheese is {cheese}, the cheesiest pasta is {pasta}, and the best beans are {beans}.";
                Console.WriteLine(randomSentence);

                //Concatenation
                string variable = "Hello";
                string compositeEx = string.Format("{0} world, and {0} class. Welcome to the gold badge.", variable);
                string interpolEx = $"{variable} world, and {variable} class. Welcome to the gold badge.";
                string concatenationEx = variable + " world, and " + variable + " class. Welcome to the gold badge.";

                Console.WriteLine(compositeEx);
                Console.WriteLine(interpolEx);
                Console.WriteLine(concatenationEx);

            // Collections
                // Array
                string[] favChar = { "A", "J", "S", "M", "D" };
                string thirdChar = favChar[2];
                Console.WriteLine(thirdChar);
                // List
                List<string> listofFruit = new List<string>();
                listofFruit.AddRange(new string[] { "Apple", "Banana", "Grape", "Kiwi", "Orange" });
    // Operators
            // Simple Math
            int a = 42;
            int b = 5;

            Console.WriteLine(a * b);
            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine(a * 2 + b);
            Console.WriteLine(a + b * 2);

            //Comparisons



            Console.ReadKey();
        }
    }
}
