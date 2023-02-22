namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            A Harshad number is a number which is divisible by the sum of its digits.For example, 132 is divisible by 6(1 + 3 + 2).

//A subset of the Harshad numbers are the Moran numbers. Moran numbers yield a prime when divided by the sum of their digits.
//                For example, 133 divided by 7(1 + 3 + 3) yields 19, a prime.

//Create a function that takes a number and returns "M" if the number is a Moran number, "H" if it is a(non - Moran) Harshad number, or "Neither".

//Examples:
//  Moran(132) ➞ "H"
//  Moran(133) ➞ "M"
//  Moran(134) ➞ "Neither"

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


            bool prime = true;
           
            for (int i = 2; i * i <= sum; i++)
            {
                if (sum % i == 0)
                {
                    prime = true;
                    
                }
            }
           


            if (copyOfInput % sum == 0 && sum == prime)
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
