namespace Exercise9
{
    internal class RollTwoDice
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Welcome to game RollTwoDice. Press enter if you want to start the game");
            Console.ReadKey();

            Console.Write("Enter a number of your desired sum from 2 - 12: ");
            var desiredSum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < desiredSum; i++)
            {              
                int dice1 = random.Next(1, 6);
                int dice2 = random.Next(1, 6);
                int diceSum = dice1 + dice2;

                if (diceSum == desiredSum)
                {
                    Console.WriteLine($"You won! You got your desired sum was: {desiredSum}");
                    break;
                }
                else if (diceSum != desiredSum)
                {
                    Console.WriteLine();
                    Console.WriteLine($"One dice you rolled was: {dice1} and second dice was: {dice2}");
                    Console.WriteLine("Continue playing. Keep rolling. Press enter");
                    Console.ReadKey();
                    continue;
                }
            }
        }
    }
}
    
