namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Write a program that picks a random number from 1 - 100.Give the user a chance to guess it.
//            If they get it right, tell them so.If their guess is higher than the number, say "Too high."
//            If their guess is lower than the number, say "Too low." Then quit. (They don't get any more guesses for now.)

//I'm thinking of a number between 1-100.  Try to guess it.
//> 13

//Sorry, you are too low.  I was thinking of 34.
//I'm thinking of a number between 1-100.  Try to guess it.
//> 79

//Sorry, you are too high.  I was thinking of 51.
//I'm thinking of a number between 1-100.  Try to guess it.
//> 42

//You guessed it!  What are the odds?!?
         
            int randomNumber = new Random().Next(1, 101);
            int userGuess = 0;
            bool endGame = false;
            Console.WriteLine("I will randomly choose a random number from 1-100. Can you guess it? \nEnter a number of your Choise?: ");
           

            while (!endGame)
            {
                 userGuess= int.Parse(Console.ReadLine());

                
                if (userGuess < randomNumber)
                {
                    Console.WriteLine($"Too low. I was thinking {randomNumber}");
                    continue;
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine($"Too high. I was thinking {randomNumber}");
                    break;
                    Console.WriteLine("Game Over");
                }
                else 
                {
                    endGame = true;
                    Console.WriteLine($"You guessed it!  What are the odds?!? I was thinking {randomNumber}");

                }
            }

            
            Console.ReadKey();
        }

        }
    }
