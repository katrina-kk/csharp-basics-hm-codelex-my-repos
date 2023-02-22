namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your weight in kg?");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your height in cm?");
            double height = Convert.ToDouble(Console.ReadLine());

            double kgToPounds = weight * 2.2;
            double cmToInches = height / 2.54;
            double bmi = Math.Round((kgToPounds  * 703) / Math.Pow(cmToInches, 2), 1);
            
            if(bmi >= 25)
            {
                Console.WriteLine($"You are owerweight. Your BMI is {bmi}");
            }
            else if(bmi <= 18.5)
            {               
                Console.WriteLine($"You are underweight.Your BMI is {bmi}");
            }
            else if(bmi >= 18.5 && bmi >= 25)
            {              
                Console.WriteLine($"Your weight is optimal. Your BMI is {bmi}");
            }                 
        }
    }
}