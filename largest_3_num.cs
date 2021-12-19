using System;
namespace three_numbers

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second  number ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third  number ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("greatest number is --- " + num1);
                }
                else
                {
                    Console.WriteLine("greatest number is --- " + num3);

                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("greatest number is ---- " + num2);
            }
            else
            {
                Console.WriteLine("greatest number is ---- " + num3);
            }






        }

    }
}
