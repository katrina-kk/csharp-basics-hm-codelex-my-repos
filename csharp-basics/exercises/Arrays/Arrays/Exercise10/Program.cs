namespace Exercise10
{
    internal class Program
    {
        //Create a function that takes an array of positive and negative numbers.
        //Return an array where the first element is the count of positive numbers and the second element is the sum of negative numbers.
        //            If given an empty array, return an empty array: []
        //            Cast sum to int, don't mind the remaining decimal places.
        //0 is not positive.
        //            CountPosSumNeg([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]) ➞ [10, -65]
        //// There are a total of 10 positive numbers.
        //// The sum of all negative numbers equals -65.

        //CountPosSumNeg([92, 6, 73, -77, 81, -90, 99, 8, -85, 34]) ➞ [7, -252]

        //CountPosSumNeg([91, -4, 80, -73, -28]) ➞ [2, -105]

        //CountPosSumNeg([]) ➞ []
        static void Main(string[] args)
        {
            int[] arr = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            Console.WriteLine(string.Join(" ", CountPosSumNeg(arr)));
            int[] arr2 = { 91, -4, 80, -73, -28 };
            Console.WriteLine(string.Join(" ", CountPosSumNeg(arr2)));
            int[] arr3 = { };
            Console.WriteLine(string.Join(" ", CountPosSumNeg(arr3)));
        }

        static int[] CountPosSumNeg(int[] arr)
        {
            int[] myArray = arr;
            int sumNegatives = 0;
            int countPositives = 0;

            if (myArray.Length == null)
            {
                return new int[0];
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > 0)
                {
                    countPositives++;
                }
                else if (myArray[i] < 0)
                {
                    sumNegatives += myArray[i];
                }
            }
            int[] positivesNegatives = { countPositives, sumNegatives };
            return positivesNegatives;
        }
    }
}
