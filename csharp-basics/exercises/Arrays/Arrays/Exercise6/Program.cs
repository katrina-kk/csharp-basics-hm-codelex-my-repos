namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            int[] values = new int[10];
            int[] values2 = new int[10];
            Random randomNum = new Random();

            for (int i = 1; i < values.Length; i++)
            {
                values[i] = randomNum.Next(1, 100);
            }                      

            values.CopyTo(values2, 0);
            values.SetValue(-7, 9);

            foreach (int item in values)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            foreach (int item in values2)
            {
                Console.Write(item + ", ");
            }
                
            Console.ReadKey();        
        }
    }
}