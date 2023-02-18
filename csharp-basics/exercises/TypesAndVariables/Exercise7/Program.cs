namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence. For fun try to use some upper case letters: ");
            string userInput = Console.ReadLine();

            int countUpperCase = 0;
            int i;

            for (i = 0; i < userInput.Length; i++)
            {
                if (char.IsUpper(userInput[i]))
                {
                    countUpperCase++;
                }
                else
                {
                    Console.Write("");
                }
            }   
            
            Console.WriteLine($"You have  written a sentence using {countUpperCase} upper case letters.");
       }
    }
 }
