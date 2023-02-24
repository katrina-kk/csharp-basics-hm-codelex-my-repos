namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            int num1 = 12;
            int num2 = 4;

            if (num1 == 15 || num2 == 15 || num1 + num2 == 15 || num1 - num2 == 15)
            {
                Console.WriteLine("true");
            }
            else
            { 
                Console.WriteLine("Not correct"); 
            }               
        }
    }
}