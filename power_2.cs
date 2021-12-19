using System;
namespace program
{
    class power
    {
        static void Main(string[] args)
        {
            int i = 0;
            int number = 0;
            Console.WriteLine("enter your power ");
            int po=Convert.ToInt32(Console.ReadLine());
            if (po < 0 || po > 31)
            {
                Console.WriteLine("number is not in range enter between 0 to 31 ");
            }
            else
            {

                int barrier = Math.Pow(2, po);
                while (i < po || number < barrier)
                {
                    int num = Math.Pow(2, i);
                    number = num;
                    Console.WriteLine(num);
                    i++;


                }
            }
        }
    }
}
