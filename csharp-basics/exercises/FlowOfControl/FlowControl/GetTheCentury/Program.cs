using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetTheCentury(1756));
            Console.WriteLine(GetTheCentury(1555));
            Console.WriteLine(GetTheCentury(1000));
            Console.WriteLine(GetTheCentury(1001));
            Console.WriteLine(GetTheCentury(2005));
        }

        static string GetTheCentury(int input) 
        {
            if (input >= 1001 && input <= 1100)
            {
                return "11th century";
            }
            else if (input >= 1101 && input <= 1200)
            {
                return "12th century";
            }
            else if(input >= 1201 && input <= 1300)
            {
                return "13th century";
            }
            else if (input >= 1301 && input <= 1400)
            {
                return "14th century";
            }
            else if (input >= 1401 && input <= 1500)
            {
                return "15th century";
            }
            else if (input >= 1501 && input <= 1600)
            {
                return "16th century";
            }
            else if (input >= 1601 && input <= 1700)
            {
                return "17th century";
            }
            else if (input >= 1701 && input <= 1800)
            {
                return "18th century";
            }
            else if (input >= 1801 && input <= 1900)
            {
                return "19th century";
            }
            else if (input >= 1901 && input <= 2000)
            {
                return "20th century";
            }
            else if (input >= 2001 && input <= 2100)
            {
                return "21th century";
            }
            else
            {
                return "Error. Number out of range";
            }           
        }           
    }
}
