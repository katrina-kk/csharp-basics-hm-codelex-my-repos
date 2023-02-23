using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits
        //the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var userInput = Int64.Parse(Console.ReadLine());

            bool tooLong = true;
            
            if (tooLong) 
            {               
                if (userInput < 0) 
                {
                    userInput *= -1;
                }
               
                if (userInput >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    int digits = 1;
                    if (userInput >= 10 && userInput < 100) 
                    {
                        digits = 2;
                    } 
                    else if (userInput >= 100 && userInput < 1000) 
                    {
                        digits = 3;
                    } 
                    else if (userInput >= 1000 && userInput < 10000) 
                    {
                        digits = 4;
                    } 
                    else if (userInput >= 10000 && userInput < 100000) 
                    {
                        digits = 5;
                    } 
                    else if (userInput >= 100000 && userInput < 1000000) 
                    {
                        digits = 6;
                    } 
                    else if (userInput >= 1000000 && userInput < 10000000) 
                    {
                        digits = 7;
                    } 
                    else if (userInput >= 10000000 && userInput < 100000000) 
                    {
                        digits = 8;
                    } 
                    else if (userInput >= 100000000 && userInput < 1000000000) 
                    {
                        digits = 9;
                    } 
                    else if (userInput >= 1000000000 && userInput < 10000000000) 
                    {
                        digits = 10;
                    }
                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }
            Console.ReadKey();
        }
    }
}
