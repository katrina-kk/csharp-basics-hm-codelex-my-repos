namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program called CheckOddEven which prints "Odd Number" if the int variable “number” is odd, or “Even Number” otherwise.
            //    The program shall always print “bye!” before exiting.

            Console.Write("Enter a number:  ");
            int userInputNumber = Convert.ToInt32(Console.ReadLine());
            CheckOddEven(userInputNumber);
            Console.ReadKey();      
        }
        static void CheckOddEven(int userInputNumber)
        {         
            if (userInputNumber % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.WriteLine("Bye!");
        }
    }
}







