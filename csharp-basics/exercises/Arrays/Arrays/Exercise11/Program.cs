namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            You need to find the word "Nemo", and return a string like this: "I found Nemo at [the order of the word you find Nemo]!".
            //                If you can't find Nemo, return "I can't find Nemo: (".
            //                FindNemo("I am finding Nemo !") ➞ "I found Nemo at 4!"

            //FindNemo("Nemo is me") ➞ "I found Nemo at 1!"

            //FindNemo("I Nemo am") ➞ "I found Nemo at 2!"
            //Hints:
            //            ! , ? . are always separated from the last word.
            //Nemo will always look like Nemo, and not NeMo or other capital variations.
            //Nemo's, or anything that says Nemo with something behind it, doesn't count as Finding Nemo.
            //If there are multiple Nemo's in the sentence, only return the first one.

            string input1 = "Nemo is me";
            string input2 = "I Nemo am";

            string[] output1 = input1.Select(x => x.ToString()).ToArray();

            //string[] output1 = new[] { input1 };
            //string[] output2 = new[] { input2 };

            //string searchNemo = "Nemo";
            int index = Array.FindIndex(output1, x => x.Contains("Nemo"));
            //Console.WriteLine("I found nemo at" + index);

            string item = "Nemo";

            string index = Array.FindIndex(item);
            


            //int index2 = Array.IndexOf(output2, searchNemo);
            //Console.WriteLine("Index of '" + searchNemo + "' : " + index);
        }
    }
}


   