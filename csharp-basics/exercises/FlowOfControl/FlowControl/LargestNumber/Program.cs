using System;

namespace LargestNumber
{
    class Program
    {      
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Int32.Parse(Console.ReadLine());           

            if (input1 >= input2 && input1 >= input3)
            {
                Console.WriteLine($"The first input {input1} is the biggest from all 3 numbers");
            }
            else if (input2 >= input1 && input2 >= input3)
            {
                Console.WriteLine($"The second input {input2} is the biggest from all 3 numbers");
            }
            else if (input3 >= input1 && input3 >= input2)
            {
                Console.WriteLine($"The third input {input3} is the biggest from all 3 numbers");
            }

            Console.ReadKey();
        }
    }
}
