using System;
namespace program
{
    public class Harmonic_sum
    {
        static void Main(string[] args)
        {
            float sum = 0;
            Console.WriteLine("enter your number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i < num)
            {
                sum += float(1/i);
                i++;

            }
            Console.WriteLine("your sum is ---> " + sum);


        }
    }
}
