namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = new int[20];
            Random randNum = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = randNum.Next(0, 20);
            }

            foreach(int i in randomNumbers)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("Which number position out of these 20 random you want to know : ");
            var position = int.Parse(Console.ReadLine());

            int index = Array.IndexOf(randomNumbers, position); 
            Console.WriteLine($"This is the position of your chosen number: {index.ToString()}");
        }
    }
}