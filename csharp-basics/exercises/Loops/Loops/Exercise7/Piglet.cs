namespace Exercise7
{
    internal class Piglet
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int result = 0;
            Random random = new Random();

            Console.WriteLine("Welcome to game Piglet. Press enter if you want to start the game");
            Console.ReadKey();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Press any key to roll the dice. If you want to end the game press 9: ");

                var userInput = Convert.ToInt32(Console.ReadLine());

                playerRandomNum = random.Next(1, 6);
                if (userInput == 9)
                {
                    Console.WriteLine($"Your score is {result}. Thanks for the game");
                    break;
                }
                else if (playerRandomNum == 1)
                {
                    Console.WriteLine("You lost. You got 0 point");
                    break;
                }
                else if (playerRandomNum == 2)
                {
                    result += playerRandomNum;
                    Console.WriteLine($"Your result is {result}");
                    continue;
                }
                else if (playerRandomNum == 3)
                {
                    result += playerRandomNum;
                    Console.WriteLine($"Your result is {result}");
                    continue;

                }
                else if (playerRandomNum == 4)
                {
                    result += playerRandomNum;
                    Console.WriteLine($"Your result is {result}");
                    continue;

                }
                else if (playerRandomNum == 5)
                {
                    result += playerRandomNum;
                    Console.WriteLine($"Your result is {result}");
                    continue;

                }
                else if (playerRandomNum == 6)
                {
                    result += playerRandomNum;
                    Console.WriteLine($"Your result is {result}");
                    continue;
                }
            }
        }
    }
}
