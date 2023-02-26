using System.Text.RegularExpressions;

namespace Exercise9
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            //Create a function that takes an array of names and returns an array where only the first letter of each name is capitalized.
            //            Don't change the order of the original array.
            //Notice in the second example above, "MABELLE" is returned as "Mabelle".

            string[] strArray = new string[] { "one", "two", "three", "four", "five", "six" }; // Creating Array of String.


            //var myArrayLower = strArray.Select(s => s.ToLowerInvariant()).ToArray();

           

        //    string mostLower = strArray.Substring(0, 1).ToUpper() + strArray.Substring(1).ToLower();
        //    // Call firstLetterCapital function for each word inside strArray array.
        //    for (int i = 0; i < strArray.Length; i++)
        //    {
        //        strArray[i] = NamesCapitalizedFirst(strArray[i]);
        //    }
        //    //This for each loop will print each element in array of string.
        //    foreach (string str in strArray)
        //    {
        //        Console.WriteLine(str);
        //    }
        //    Console.ReadKey();
        //}
        //static string NamesCapitalizedFirst(string names)
        //{
           
        //    string firstLetter = names.Substring(0, 1);  //Take first letter as new string,
        //                                               // this done with help of substring method of String class.
        //    string firstLetterCapital = firstLetter.ToUpper();
        //    string strExcludeFirstLetter = names.Substring(1, names.Length);
        //    // Final string will be firstLetterCapital followed by strExceptFirstLetter.
        //    string result = firstLetterCapital + strExcludeFirstLetter;
        //    return result;
        }
        
        // This function will return new copy of str (input string) but with first letter as capital.
        // Notice this function is static because we going to call this function from main method. and main method is static.
        
    }
}