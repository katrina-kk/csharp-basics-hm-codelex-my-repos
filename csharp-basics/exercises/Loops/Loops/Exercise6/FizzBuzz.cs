namespace Exercise6
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Input number in range of 1 - 100 : ");
            var userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= userInput; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }               
                else
                {
                    Console.Write($"{i} ");
                }

                if (i % 20 == 0)
                {
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }
    }
}