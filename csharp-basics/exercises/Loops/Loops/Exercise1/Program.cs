﻿using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("The first 10 natural numbers are: ");

            for (i = 1; i < 11; i++)
            {
                Console.Write($"{i}, ");
            }
            Console.ReadKey();
        }
    }
}
