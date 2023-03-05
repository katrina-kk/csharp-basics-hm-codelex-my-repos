using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {            
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };   
            string str = new string(vowels);

            for(int i = 0; i < 1; i++)
            {
                Console.WriteLine(str);
            }

            foreach(char c in vowels)
            {
                Console.Write(c);
            }      
            
            Console.ReadLine();
        }
    }
}
