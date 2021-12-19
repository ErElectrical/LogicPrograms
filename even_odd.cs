using System;
namespace program
{
    public class even_odd
    {
        static void Main(string [] args)
        {
            Console.WriteLine(" enter your number ");
            int num = Convert.ToInt32 (Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("number is even ");
            }
            else if (num % 2 != 0)
            {
                Console.WriteLine("number is odd ");
            }

            
        }
    }
}
