using System;
namespace program
{
    public class vowel_consent
    {
        static void Main(string [] args )
        {
            Console.WriteLine(" enter your charcetr :  ");
            string alpha = Console.ReadLine();
            if (alpha == "a" || alpha == "e" || alpha == "i" || alpha == "o" || alpha == "u")
            {
                Console.WriteLine("found a vowel ");
            }
            else
            {
                Console.WriteLine("found a consent ");
            }

        }
    }
}
