namespace Exercise8_Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Write a program to play a word - guessing game like Hangman.

            //It must randomly choose a word from a list of words.
            //It must stop when all the letters are guessed.
            //It must give them limited tries and stop after they run out.
            //It must display letters they have already guessed(either only the incorrect guesses or all guesses).

            string[] words = { "cat", "dog", "bird" };
            Random random = new Random();
            int index = random.Next(words.Length);
            string wordToGuess = words[index];

            foreach (var letter in wordToGuess)
            {
                Console.Write(" _ ");
            }

            
            bool isStringEmpty = true;
            string letterFromUser;

            while (isStringEmpty)
            {
                Console.WriteLine("Please enter a letter: ");
                letterFromUser = Console.ReadLine();

                if (string.IsNullOrEmpty(letterFromUser))
                {
                    Console.WriteLine("Error!Please enter one letter!: ");
                }
                break;
            }

            if (wordToGuess.ToUpper().Contains(letterFromUser.ToUpper()))
            {
                Console.WriteLine
            }
            else
            {

            }
        }
    }
}