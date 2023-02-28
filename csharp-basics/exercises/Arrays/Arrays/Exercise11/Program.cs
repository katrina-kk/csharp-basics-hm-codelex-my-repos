namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindNemo("I am Nemo");
            FindNemo("Nemo is here");
            FindNemo("Elmo is here");      
        }

        static int GetIndexNemo(string findNemo)
        {
            string[] words = findNemo.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "Nemo")
                {
                    return (i + 1);
                }
            }

            return 0;
        }

        static string FindNemo(string input)
        {
            string findNemo = " ";
            int x = GetIndexNemo(input);

            if (x != 0)
            {
                Console.WriteLine($"I found Nemo at {x}!");
            }
            else
            {
                Console.WriteLine("I can't find Nemo");
            }
            return findNemo;
        }
    }
}



