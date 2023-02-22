namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FooCorp(basePay: 7.50, hoursWorked: 35));
            Console.WriteLine(FooCorp(basePay: 8.20, hoursWorked: 47));
            Console.WriteLine(FooCorp(basePay: 10.00, hoursWorked: 73));
            Console.ReadKey();
        }

        static string FooCorp(double basePay, double hoursWorked)
        {          
            int workWeekHours = 40;            
            double overtimePay = basePay * 1.5;
            double minimumWage = 8.00;
            
            if(basePay < minimumWage || hoursWorked > 60)
            {
                return "Error! Either your basePay is too low or you have worked too much hours";
            }
            else if(basePay >= minimumWage && hoursWorked <= workWeekHours)
            {
                return $"Your pay for this week is {basePay * hoursWorked} $.";
            }
            else if(basePay >= minimumWage && hoursWorked >= workWeekHours && hoursWorked <= 60)
            {
                return $"Your pay for this week is {(basePay * workWeekHours) + ((hoursWorked - workWeekHours) * overtimePay)}$.";
            }           
            else
            {
                return "";
            }
        }
    }
}