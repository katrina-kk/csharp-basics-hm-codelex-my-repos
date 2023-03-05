namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word 1: ");
            var word1 = Console.ReadLine();
            Console.WriteLine("Enter word 2: ");
            var word2 = Console.ReadLine();
            
            var concat = word1 + word2;
            int stringLength = concat.Length;
            var dotsLength = 30 - stringLength;
            var dots = ".";

            Console.Write(word1);
            for(int i = 0; i < dotsLength; i++)
            {                
                Console.Write(dots);
            }
            Console.WriteLine(word2);
        }
    }
}