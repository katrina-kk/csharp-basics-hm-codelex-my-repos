namespace Exercise7
{
    internal class Piglet
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int result = 0;
            Random random = new Random();

            Console.WriteLine("Welcome to game Piglet. Press Y on the keyboard if you want to start the game");
            Console.ReadKey();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Roll again? Press 1 to continue. Press 9 to end the game.  ");
               
                var userInput = Convert.ToInt32(Console.ReadLine());

                playerRandomNum = random.Next(1, 6);
                if (userInput == 9)
                {
                    Console.WriteLine($"Your score is {result}. Thanks for the game");
                    break;
                }
                else if (playerRandomNum == 1)
                {
                    Console.WriteLine("You rolled a 1! You got 0 point");
                    break;
                }
                else if (playerRandomNum == 2)
                {
                    result += playerRandomNum;
                    Console.WriteLine($"You rolled a {playerRandomNum}. ");
                    continue;
                }
                else if (playerRandomNum == 3)
                {
                    result += playerRandomNum;
                    Console.WriteLine($"You rolled a {playerRandomNum}. ");
                    continue;

                }
                else if (playerRandomNum == 4)
                {
                    result += playerRandomNum;
                    Console.WriteLine($"You rolled a {playerRandomNum}. ");
                    continue;

                }
                else if (playerRandomNum == 5)
                {
                    result += playerRandomNum;
                    Console.WriteLine($"You rolled a {playerRandomNum}.");
                    continue;

                }
                else if (playerRandomNum == 6)
                {
                    result += playerRandomNum;
                    Console.WriteLine($"You rolled a {playerRandomNum}.");
                    continue;
                }
            }
        }
    }
}
