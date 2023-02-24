namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int randomNumber = new Random().Next(1, 101);   

            Console.WriteLine("I will randomly choose a random number from 1-100. Can you guess it? \nEnter a number of your Choise?: ");
            int userGuess = int.Parse(Console.ReadLine());

                if (userGuess <= randomNumber)
                {
                    Console.WriteLine($"Too low. I was thinking {randomNumber}");
                    Console.WriteLine("Game Over");
                }
                else if (userGuess >= randomNumber)
                {
                    Console.WriteLine($"Too high. I was thinking {randomNumber}");                    
                    Console.WriteLine("Game Over");
                }
                else if (userGuess == randomNumber)
                {
                    Console.WriteLine($"You guessed it!  What are the odds?!? I was thinking {randomNumber}");                  
                }              
                Console.ReadKey();
        }           
    }
}

