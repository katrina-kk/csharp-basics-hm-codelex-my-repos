namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Šī piramīdu shēma man tā salauza prātu, ka nevarēju līdz samazināšanas formulai nonākt.Ar matemātiku uz jūs.

            for (int rows = 0; rows < 5; rows++)
            {
                for (int toTheRight = 16; toTheRight > (rows * 4); toTheRight--)  // Slash "/" aizpilda visas vietas, ar katru ciklu tās samazinās un to vietā nāk zvaigznītes
                {
                    Console.Write("/");
                }
                for (int stars = 0; stars < (rows * 8); stars++)
                {
                    Console.Write("*");
                }
                for (int toTheLeft = 16; toTheLeft > (rows * 4); toTheLeft--)  
                {
                    Console.Write(@"\");
                }

                Console.WriteLine();
            }
        }
    }
}
