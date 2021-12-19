using System;
namespace program
{
    public class Program
    {
        static void Main(string [ ] args)
        {
            Console.WriteLine("enter your year ");
            string year=Console.ReadLine();
            if ( year.Length != 4)
            {
                Console.WriteLine(" enter year having 4 integer only ");
            }
            else
            {
                int y = Convert.ToInt32(year);
                if (y % 4 ==0 || y % 100 ==0)
                {
                    Console.WriteLine("it is a leap year");
                }
                else
                {
                    Console.WriteLine("not a leap year");
                }
            }
        }
    }
}