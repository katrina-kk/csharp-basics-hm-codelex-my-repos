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
            int menuChoice;

            do
            {
                 menuChoice = GetMenu();
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
                    Console.WriteLine("Bye");
                }
            } while (menuChoice != 4);         
        }

        public static int GetMenu()
        {
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");

            var keyboard = Int32.Parse(Console.ReadLine());

            if (UserChoiceValidation(keyboard))
            {
                Console.WriteLine("");               
            }
            return keyboard;
        }

        public static void CalculateCircleArea()
        {          
            Console.WriteLine("What is the circle's radius? ");
            decimal radius = (decimal)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The circle's area is " + Geometry.AreaOfCircle(radius));         
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;
  
            Console.WriteLine("Enter length? ");
            var keyboard = Console.ReadLine();

            Console.WriteLine("Enter width? ");
             keyboard = Console.ReadLine();

            Console.WriteLine("The rectangle's area is " + Geometry.AreaOfTriangle(length, width));          
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;
  
            Console.WriteLine("Enter length of the triangle's base? ");
          var keyboard = Console.ReadLine();
   
            Console.WriteLine("Enter triangle's height? ");
             keyboard = Console.ReadLine();
  
            Console.WriteLine("The triangle's area is " + Geometry.AreaOfRectangle(ground, height));            
        }
        private static bool UserChoiceValidation(int userInput) 
        {
            var selection = new int[] { 1, 2, 3, 4 };
            return selection.Contains(userInput); 
        }
    }
}
