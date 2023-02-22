using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Design a Geometry class with the following methods:

            //A static method that accepts the radius of a circle and returns the area of the circle.Use the following formula:
            //Area = π* r * 2
            //Use Math.PI for π and r for the radius of the circle
            //A static method that accepts the length and width of a rectangle and returns the area of the rectangle.Use the following formula:
            //Area = Length x Width
            //A static method that accepts the length of a triangle’s base and the triangle’s height.The method should return the area of the triangle.
            //Use the following formula:
            //Area = Base x Height x 0.5
            //The methods should display an error message if negative values are used for the circle’s radius, the rectangle’s length or width,
            //or the triangle’s base or height.

            //Next write a program to test the class, which displays the following menu and responds to the user’s selection:

            //Geometry calculator:

            //Calculate the Area of a Circle
            //Calculate the Area of a Rectangle
            //Calculate the Area of a Triangle
            //Quit
            //Enter your choice(1-4):
            //Display an error message if the user enters a number outside the range of 1 through 4 when selecting an item from the menu.

            // Get the user's menu choice.
            // pēc keys (switch if) jānolasa un jāizdara metode. 

            
            

                // Get the user's menu choice.

               int  menuChoice = GetMenu();

                if (menuChoice == 1)
                {

                    CalculateCircleArea();

                }
                else if (menuChoice == 2)
                {

                    CalculateRectangleArea();

                }
                else if (menuChoice == 3)
                {

                    CalculateTriangleArea();

                }
                else if (menuChoice == 4)
                {

                  Console.WriteLine("Quit");

                }
                else if (menuChoice > 4)
                {
                    Console.WriteLine("Error");
                }

            
        }

        public static int GetMenu()
        {

            int userChoice;
            

            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            // get input from user
            int input = Convert.ToInt32(Console.ReadLine());
            // validate input

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            var keyboard = Console.ReadLine();

            

            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            // Get input from user
            var keyboard = Console.ReadLine();
            // Get length
            Console.WriteLine("Enter length? ");
            //todo

            // Get width
            Console.WriteLine("Enter width? ");
            //todo

            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            // Get input from user
            
            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
          var keyboard = Console.ReadLine();
            //todo
            //read key value

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            //todo
            //read key value
            

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
