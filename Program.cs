using System;


namespace NumberGuesser
{
    class Program
    {
        //Entry point method
        static void Main(string[] args)
        {
            // Run to get app info 
            GetAppInfo();

            // Ask for user name and greet user 
            GreetUser();

            while (true)
            {
                // Init correct number 
                //int correctNumber = 7;

                // ***Create a new random object*** 
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number 
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct number
                while (guess != correctNumber)
                {
                    // Get user input 
                    string input = Console.ReadLine();

                    // ***Make sure its  a number***
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going 
                        continue;

                    }

                    // ***Cast to int and put in guess***
                    guess = Int32.Parse(input);

                    // Match guess to correct number 
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                        // Reset text colour
                        Console.ResetColor();
                    }
                }
                // Output success message

                //Print correct message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                // Reset text colour
                Console.ResetColor();

                // Ask to pay again 
                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                
                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        // Show app info
        static void GetAppInfo()
        {
            // Set app vars 
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Vinat K";

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info 
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text colour
            Console.ResetColor();
        }
       
        // Get user name and greet user 
        static void GreetUser()
        {
            // Ask user name 
            Console.WriteLine("What is your name?");

            //Get user input 
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game....", inputName);
  
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text colour
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text colour
            Console.ResetColor();
        }
    }
}
