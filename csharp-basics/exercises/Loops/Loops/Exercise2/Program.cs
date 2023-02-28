using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {           
            int i;
            Console.WriteLine("Input number to multiply with itself: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number how many times to multiply that number: ");
            var power = Convert.ToInt32(Console.ReadLine());
           
            var answer = 1;

            for ( i = 0; i < number; i++)
            {
                answer = answer * power;
            }

           Console.WriteLine(answer);
           Console.ReadKey();
        }
    }
}
