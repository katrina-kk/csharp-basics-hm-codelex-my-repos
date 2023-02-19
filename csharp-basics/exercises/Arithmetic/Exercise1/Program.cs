namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to accept two integers and return true if the
            //either one is 15 or if their sum or difference is 15.
            int num1 = 12;
            int num2 = 4;

            if (num1 == 15 || num2 == 15 || num1 + num2 == 15 || num1 - num2 == 15)
                Console.WriteLine("true");
            else
                Console.WriteLine("Not correct");
        }
    }
}