namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
           
            Console.WriteLine("Enter how many numbers you would like to sum up? ");
            int userInputTotal = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userInputTotal; i++)
            {
                Console.WriteLine("Enter a number: ");
                int userInputNumbers = Convert.ToInt32(Console.ReadLine());
                sum += userInputNumbers;
            }

            Console.WriteLine($"The sum of your numbers is: {sum}.");
            Console.ReadKey();             

        }
    }
}