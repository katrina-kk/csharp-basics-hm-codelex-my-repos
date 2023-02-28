namespace Exercise11
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to find Nemo? Write one sentence using word Nemo in it or choose not to: ");
            string findNemo = Console.ReadLine();

            int nemoIndex = GetIndexNemo(findNemo);

            if (nemoIndex != 0)
            {
                Console.WriteLine($"I found Nemo at {nemoIndex}!");
            }
            else
            {
                Console.WriteLine("I can't find Nemo");
            }

            Console.ReadLine();       
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
    }   
}



