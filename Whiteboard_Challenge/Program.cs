using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 16;
            Console.WriteLine(numOne);

            string firstName = "Aaron";
            Console.WriteLine(firstName);

            DateTime today = DateTime.Today;
            DateTime tomorrow = new DateTime(2020, 8, 1);
            Console.WriteLine(DateTime.Today);

            int numTwo = 83;

            int difference = numTwo - numOne;
            Console.WriteLine("The difference of " + numTwo + " and " + numOne + " is " + difference);

            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            string interpolatedFullName = $"{myName} {lastName}";

            Console.WriteLine("Hello " + interpolatedFullName);

            Console.ReadLine();

            Console.WriteLine("Are you wearing pants? Y/N");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Y":
                    Console.WriteLine("Congratulations, you're wearing pants");
                    break;
                case "N":
                    Console.WriteLine("That's fine, class is remote anyway.");
                    break;
                default:
                    Console.WriteLine("We don't recognize your answer, but we'll just assume you are wearing pants.");
                    break;
            }

            bool happy = true;

            Console.WriteLine("Are you happy?");
            string result = Console.ReadLine();
            // this conditional is essentially if the bool is true
            if (result == "yes" || result == "Yes")
            {
                happy = true;
            }
           
            else if (result == "no" || result == "No")
            {
                happy = false;
            }

            else
            {
                Console.WriteLine("Whatever, you can't even answer a simple yes or no?");
            }
            if (happy)
            {
                Console.WriteLine("Good for you");
            }
            else  Console.WriteLine("You should try and work on that");

            Console.WriteLine("How much money do you make?");
            int money = int.Parse(Console.ReadLine());

            if (money <= 1000 && money >= 10000)
            {
                Console.WriteLine("User makes between one thousand and ten thousand dollars.");
             
            }  
            else if (money <= 11000 && money >= 50000)
            {
                Console.WriteLine("User makes between eleven thousand and fifty thousand dollars.");
            }
            else if (money <= 51000 && money >= 100000)
            {
                Console.WriteLine("User makes between fifty one thousand and one hundred thousand dollars");
            }
            else
            {
                Console.WriteLine("User did not input correctly");
            }
        }
    }
}
