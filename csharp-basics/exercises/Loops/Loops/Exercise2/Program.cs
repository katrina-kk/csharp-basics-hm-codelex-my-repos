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
       
            var answer = 1;

            for ( i = 0; i < number; i++)
            {
                answer = answer * number;
            }

           Console.WriteLine(answer);
           Console.ReadKey();
        }
    }
}
