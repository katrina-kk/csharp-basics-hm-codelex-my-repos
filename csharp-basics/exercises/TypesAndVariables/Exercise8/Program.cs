namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert how many minutes you would like to convert?: ");
            int inputMinutes = Convert.ToInt32(Console.ReadLine());

            int minutesInYear = 365 * 24 * 60;
            int minutesInDay = 24 * 60;
            int year = inputMinutes / minutesInYear;
            int remainingMinutes = inputMinutes % minutesInYear;
            int day = remainingMinutes / minutesInDay;

            Console.WriteLine($"Your chosen {inputMinutes} is {year} years and {day} days");
            Console.ReadKey();
        }
    }
}