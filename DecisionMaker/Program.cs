using System;

namespace DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            string userName;
            bool keepGoing = true;
            char continueQuery;

            Console.WriteLine("Hey there, what's your name?");
            userName = Console.ReadLine();

            while (keepGoing) {
                Console.WriteLine($"{userName}, please enter an integer between 1 and 100.");
                userNumber = Convert.ToInt32(Console.ReadLine());

                while (!isValidNumber(userNumber))
                {
                    Console.WriteLine($"Sorry {userName}, that number is out of range! Please enter an integer beweeen 1 and 100.");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                }

                if (!isEven(userNumber)) {
                    Console.WriteLine($"{userNumber} is Odd.");
                }
                else if (isEven(userNumber) && userNumber >= 2 && userNumber <= 25) {
                    Console.WriteLine("Even and less than 25.");
                }
                else if (isEven(userNumber) && userNumber >= 26 && userNumber <= 60)
                {
                    Console.WriteLine("Even.");
                }
                else if (isEven(userNumber) && userNumber > 60)
                {
                    Console.WriteLine($"{userNumber} is Even.");
                }

                Console.WriteLine($"Should we try another number, {userName}? y/n");
                continueQuery = char.Parse(Console.ReadLine());

                while (continueQuery != 'n' && continueQuery != 'y') {
                    Console.WriteLine("I didn't understand that. Should we try another number? y/n");
                    continueQuery = char.Parse(Console.ReadLine());
                }

                if (continueQuery == 'n')
                {
                    Console.WriteLine($"Thanks for playing {userName}, see you next time!");
                    break;
                }
            }

            static bool isEven(int number)
            {
                return number % 2 == 0;
            }

            static bool isValidNumber(int number) {
                return number >= 1 && number <= 100;
            }
        }
    }
}
