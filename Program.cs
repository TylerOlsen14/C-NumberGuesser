using System;

// namespace
namespace NumberGuesser
{
    // main class
    class Program
    {
        //// entry point method
        //static void Main(string[] args) //return type of this particular function
        //{

        //    string name = "Tyler Olsen";
        //    int age = 29;
        //    // Start Here //
        //    Console.WriteLine("Hello World"); // function
        //    Console.WriteLine(name); // using function to show variable
        //    Console.WriteLine("Hello " + name+".");
        //    Console.WriteLine("You are " + age + " years old.");
        //    Console.WriteLine("{0} is {1} years old.", name, age);
        //}
        // entry point method
        static void Main(string[] args) //return type of this particular function
        {
            GetAppInfo(); // Run GetAppInfo function to get info

            GreetUser(); // Ask for user's name and greet

            // loop to wrap around the game
            while (true) { 

                // Start the game
                // init correct number
                //int CorrectNumber = 7;

                // Create new random object
                Random random = new Random();

                // Inut correct number
                int CorrectNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // while guess in incorrect
                while (guess != CorrectNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // ensure correct input entry
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");

                        // keep going
                        continue;
                    }

                    // Cast to int & input guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != CorrectNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Output success message

                //Print error message
                PrintColorMessage(ConsoleColor.Yellow, "Correct!"); ;

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y") {
                    continue;
                } 
                else if(answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Get and dispaly app info
        static void GetAppInfo(){
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Tyler Olsen";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app information
            Console.WriteLine("{0}: Verion {1} by {2}", appName, appVersion, appAuthor);

            // Change back to standard
            Console.ResetColor();
        }

        // Ask name and greet
        static void GreetUser(){
            // Ask user name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // return their name
            Console.WriteLine("Hello {0}, let's play a game . . . ", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message){
            // Change text color
            Console.ForegroundColor = color;

            // Error
            Console.WriteLine(message);

            // Change back to standard
            Console.ResetColor();
        }

    }
}
