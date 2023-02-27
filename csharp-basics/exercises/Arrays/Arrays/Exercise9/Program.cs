using System.Globalization;
using System.Text.RegularExpressions;

namespace Exercise9
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", FirstLetterCapitalized()));
        }

        static string[] FirstLetterCapitalized()
        {
            string[] myArray = { "JANIS", "elina", "Anna", "ZIGMARS", "MABELLE" }; 

            string words = string.Join(",", myArray).ToLower();

            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
            string output = cultInfo.ToTitleCase(words);

            Console.WriteLine(output);

            string[] wordsCapitalized = new string[myArray.Length];

            return wordsCapitalized;           
        }
    }
}