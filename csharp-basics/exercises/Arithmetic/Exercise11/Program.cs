namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moran(132);
            Moran(133);
            Moran(134);
        }
       private static void Moran (int n)
        {
            int sum = 0;
            int remainderOfNumber = 0;
            int copyOfInput = n;
            
            while(n != 0)
            {
                remainderOfNumber = n % 10;
                sum = sum + remainderOfNumber;
                n = n / 10;
            }

            bool prime = false;
           
            for (int i = 2; i * i <= sum; i++)
            {
                if (sum % i == 0)
                {
                    prime = true;
                    
                }
            }           

            if (copyOfInput % sum == 0 && prime == false)
            {
                Console.WriteLine("M");
            }
            else if (copyOfInput % sum == 0)
            {
                Console.WriteLine("H");
            }           
            else
            {
                Console.WriteLine("Neither");
            }
        }     
    }
}
