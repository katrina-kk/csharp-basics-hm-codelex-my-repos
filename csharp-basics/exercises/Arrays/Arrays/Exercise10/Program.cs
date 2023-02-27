namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
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

            int[] myArray = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };

            Console.WriteLine(CountPosSumNeg(myArray));


        }

        static int[] CountPosSumNeg(int[] arr)
        {
            int[] myArray = new int[2];
            int sum = 0;


            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > 0)
                {

                }
                else if (myArray[i] < 0)
                {
                    sum += myArray[i];
                }
                else
                {

                }

                return arr;

            }
        }
    }
}
           