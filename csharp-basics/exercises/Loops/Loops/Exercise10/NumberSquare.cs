namespace Exercise10
{
    internal class NumberSquare
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Insert min number you want your patter to start with");
            var userInputMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert max number you want your patter to end with");
            var userInputMax = Convert.ToInt32(Console.ReadLine());          

            for(int i = userInputMin; i <= userInputMax; i++)
            {
                for (int j = i; j <= userInputMax; j++)
                {
                    Console.Write(j);                   
                }
                for (int k = userInputMin; k < i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();              
            }
        }
    }
}