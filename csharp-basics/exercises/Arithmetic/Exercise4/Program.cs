namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine(Product1ToN(10));
            Console.ReadKey();
        }

        static int Product1ToN(int n) 
        {
            int result = 1;

            for(int i = 2; i <= n ; i++)
            {                          
               result = result * i;
            }
            return result;
        }
    }
}