namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {                    
            Console.Write("Input what kind of distance(in meters) you finished?: ");
            float distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input full time(hours, minutes, seconds) it took you to finish the distance.\nStart with how many hours it took you to finish this distance: ");
            float hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input how many minutes it took you to finish that distance: ");
            float minutes = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input how many seconds it took you to finish that distance: ");
            float seconds = Convert.ToSingle(Console.ReadLine());

            float timeTotalSeconds = (hour * 3600) + (minutes * 60) + seconds;
            float metersPerSecond = distance / timeTotalSeconds;
            float kmPerHour = (distance / 1000.0f) / (timeTotalSeconds / 3600.0f);
            float milesPerHour = kmPerHour / 1.609f;

            Console.WriteLine("\nYour speed in metres/sec is {0}", metersPerSecond);
            Console.WriteLine("Your speed in km/h is {0}", kmPerHour);
            Console.WriteLine("Your speed in miles/h is {0}", milesPerHour);
        }
    }
}