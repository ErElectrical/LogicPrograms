using System;
namespace program
{
    class flip_coin
    {
        static void Main(string[] args)
        {
            int head_count = 0;
            int tails_count = 0;
            Random rem = new Random();
            int i = 0;
            // we will count percentage based on the iteration upto 10
            while(i < 10)
            {
                int check = rem.Next(0, 2);
                if(check == 0)
                {
                    head_count++;
                }
                else if (check == 1)
                {
                    tails_count++;
                }
                i++;
            }

            float head_percentage = (float(head_count / 10)) * 100;
            float tails_percentage=(float(tails_count /10)) * 100;
            Console.WriteLine("head percentage is --- " + head_percentage);
            Console.WriteLine("tails percentage is --- " + tails_percentage);
            Console.WriteLine("head occurs --- " + head_count);
            Console.WriteLine("tails occurs---- " + tails_count);
            
        }
    }
}
