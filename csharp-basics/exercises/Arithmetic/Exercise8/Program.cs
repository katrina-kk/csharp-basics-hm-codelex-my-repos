namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Foo Corporation needs a program to calculate how much to pay their hourly employees. 
            //                The US Department of Labor requires that employees get paid time and a half for any hours over 40 that they work in a single week.
            //                For example, if an employee works 45 hours, they get 5 hours of overtime, at 1.5 times their base pay.
            //                The State of Massachusetts requires that hourly employees be paid at least $8.00 an hour. 
            //                Foo Corp requires that an employee not work more than 60 hours in a week.

            //Summary
            //An employee gets paid(hours worked) × (base pay), for each hour up to 40 hours.
            //For every hour over 40, they get overtime = (base pay) × 1.5.
            //The base pay must not be less than the minimum wage($8.00 an hour).If it is, print an error.
            //If the number of hours is greater than 60, print an error message.
            //Write a method that takes the base pay and hours worked as parameters, and prints the total pay or an error.
            //Write a main method that calls this method for each of these employees:

            //Employee    Base Pay    Hours Worked
            //Employee 1	$7.50   35
            //Employee 2	$8.20   47
            //Employee 3	$10.00  73

            

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