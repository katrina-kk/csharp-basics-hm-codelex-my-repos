namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Write a program that calculates and displays a person's body mass index (BMI).
            //                A person's BMI is calculated with the following formula: BMI = weight x 703 / height ^ 2.
            //                Where weight is measured in pounds and height is measured in inches.Display a message indicating whether the person has optimal weight, 
            //                is underweight, or is overweight.A sedentary person's weight is considered optimal if his or her BMI is between 18.5 and 25. 
            //                If the BMI is less than 18.5, the person is considered underweight. 
            //                If the BMI value is greater than 25, the person is considered overweight.

            //Your program must accept metric units.

            Console.WriteLine("What is your weight?");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your height?");
            double height = Convert.ToDouble(Console.ReadLine());

            double poundsToKG = weight * 0.45;
            double inchesToCM = height * 2.54;
            double bmiToMetric = ((weight * 0.45) * 703) / Math.Pow(inchesToCM, 2));
            

            if(bmiToMetric >= 25)
            {
                Console.WriteLine($"You are owerweight. Your BMI is {Math.Round(bmiToMetric, 2)}");
            }
            else if(bmiToMetric <= 18.5)
            {
               
                Console.WriteLine($"You are underweight.Your BMI is {Math.Round(bmiToMetric, 2)}");
            }
            else if(bmiToMetric >= 18.5 && bmiToMetric >= 25)
            {
                
                Console.WriteLine($"Your weight is optimal. Your BMI is {Math.Round(bmiToMetric, 2)}");
            }
            Console.ReadKey();

           
            
        }
    }
}