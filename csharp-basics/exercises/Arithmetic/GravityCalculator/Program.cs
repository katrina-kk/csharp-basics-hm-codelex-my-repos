
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
//            Modify the example program to compute the position of an object after falling for 10 seconds, 
//                outputting the position in meters.The formula in Math notation is:

//Gravity formula

//Note: The correct value is -490.5m.

            double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = 0.0;
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}
