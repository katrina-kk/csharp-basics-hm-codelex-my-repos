namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program called Product1ToN to compute the product of integers from 1 to 10
            //(i.e., 1×2×3×...×10), 
            //    as an int.Take note that It is the same as factorial of N.
            //vajag programmu kas sareizina skaitļus no 1 līdz N

            //i++; 
            //i += 1;
            //i = i + 1;
            //x = x + y;
            // x += y;
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