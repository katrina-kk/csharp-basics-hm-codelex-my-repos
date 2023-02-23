namespace Exercise5
{
    internal class PhoneKeyPad
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Enter a text you want to send: ");
            string userText = Console.ReadLine().ToLower();
           
            for (int i = 0; i < userText.Length; i++)
            {
                char letters = userText.ToCharArray()[i];

                if (letters == 'a' || letters == 'b' || letters == 'c')
                {
                    Console.Write(2);
                }
                else if (letters == 'd' || letters == 'e' || letters == 'f')
                {
                    Console.Write(3);
                }
                else if (letters == 'g' || letters == 'h' || letters == 'i')
                {
                    Console.Write(4);
                }
                else if (letters == 'j' || letters == 'k' || letters == 'l')
                {
                    Console.Write(5);
                }
                else if (letters == 'm' || letters == 'n' || letters == 'o')
                {
                    Console.Write(6);
                }
                else if (letters == 'p' || letters == 'q' || letters == 'r' || letters == 's')
                {
                    Console.Write(7);
                }
                else if (letters == 't' || letters == 'u' || letters == 'v')
                {
                    Console.Write(8);
                }
                else if (letters == 'w' || letters == 'x' || letters == 'y' || letters == 'z')
                {
                    Console.Write(9);
                }
                else
                {
                    Console.WriteLine("Error");
                    break;
                }
            }
        }
    }
}