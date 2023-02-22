namespace Exercise6
{
    internal class CozaLozaWoza
    {
        static void Main(string[] args)
        {        
            for (int i = 1; i <= 111; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Coza ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("CozaLoza ");
                }             
                else if (i % 5 == 0)
                {
                    Console.Write("Loza ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
                if (i % 11 == 0)
                {
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }

    }
}

       
    

    
