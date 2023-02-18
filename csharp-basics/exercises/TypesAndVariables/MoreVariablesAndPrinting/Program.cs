using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Zed A. Shaw";
            int age = 35;
            int height = 74;  
            int weight = 180; 
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";
            double heightInCm = height * 2.54;
            double weightInKg = weight * 0.453592;
            double totalMetricSystemSum = age + heightInCm + weightInKg;

            Console.WriteLine($"Let's talk about {name}.");
            Console.WriteLine($"He's {height} inches tall.");
            Console.WriteLine($"He's {weight} pounds heavy.");
            Console.WriteLine($"Actually, that's not too heavy.");
            Console.WriteLine($"He's got {eyes} eyes and {hair} hair.");
            Console.WriteLine($"His teeth are usually {teeth} depending on the coffee.");

            Console.WriteLine($"If I add {age}, {heightInCm:0.00}, and {weightInKg:0.00}.  I get {totalMetricSystemSum:0.00}.");

            Console.ReadKey();
        }
    }
}