namespace Exercise8_Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            string[] words = { "donkey", "dog", "bird" };
            List<string> usedLetters = new List<string>();      
            int retryCount = 0;
            Random random = new Random();
            string printableWord = "";
            int index = random.Next(words.Length);
            string wordToGuess = words[index];

            Console.WriteLine("Hello, This is a game Hangman. Let's guess a word. ");

            //replace letters with placeholders in printable version
            foreach (var letter in wordToGuess)
            {              
                printableWord += "_";
            }

            foreach(var letter in printableWord)
            {
                Console.Write($"{letter} ");
            }

            string letterFromUser = null!;
            bool repeatGameAction = true;
            bool isInputValid = true;

            while (repeatGameAction)
            {
               
                //get letter from user
                while (isInputValid)
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
                    //convert to char array to use index for replacing letters
                    var charArr = printableWord.ToCharArray();

                    // swap underscores to letters
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i].ToString().ToUpper() == letterFromUser.ToUpper())
                        {
                            charArr[i] = letterFromUser.ToUpper()[0];
                        }
                    }
                    //re-assing new value
                    printableWord = string.Join("", charArr);
                }
                else
                {
                    if (!usedLetters.Contains(letterFromUser.ToUpper()))
                    {
                        usedLetters.Add(letterFromUser.ToUpper());
                    }

                    ++retryCount;

                    if(retryCount >= words.Length)
                    {
                        Console.WriteLine("Game Over! No more tries");
                        break;
                    }
                    
                }

                foreach (var letter in printableWord)
                {
                    Console.Write($"{letter} ");
                }

                Console.WriteLine();
                Console.WriteLine($"Retry count: {retryCount}");

                Console.WriteLine($"Used letters: {string.Join(",", usedLetters)}");

                if(!printableWord.Contains("_"))
                {
                    Console.WriteLine("You won. Congratz!!!");
                    break;
                }
            }           
        }
    }
}