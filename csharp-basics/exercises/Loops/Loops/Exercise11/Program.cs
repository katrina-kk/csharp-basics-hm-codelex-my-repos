namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            ReverseCase("Happy Birthday");
            ReverseCase("MANY THANKS");
            ReverseCase("sPoNtAnEoUs");
        }

        static string ReverseCase(string reverse)
        {           
            char[] charString = reverse.ToCharArray();

            for (int i = 0; i < charString.Length; i++)
            {
                char ch = charString[i];
                if (char.IsLower(ch))
                {
                    Console.Write(char.ToUpper(ch));
                }
                else
                {
                    Console.Write(char.ToLower(ch));
                }
                string charBackToString = new string(charString);
                charBackToString = reverse;
            }
            Console.WriteLine();
            return reverse;
        }
    }
}




