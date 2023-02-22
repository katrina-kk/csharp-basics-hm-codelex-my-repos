using System;

namespace SumAverageRunningInt
{
    public class  SumAverageRunningInt
    {
        static void Main(string[] args)
        {
            var sum = 0;
            double average = 0;
            const int lowerBound = 1;
            const double upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
            }
            average = sum / upperBound;
            Console.WriteLine($"The sum of 1 to 100 is {sum} \n The average is {average: 0.0}");
        }
    }
}

