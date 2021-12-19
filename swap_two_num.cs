using System;
namespace program
{
    public class swap_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number -- ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number -- ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before opreation --- ");
            Console.WriteLine("a -- "+a);
            Console.WriteLine("b -- "+b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after opreation --- ");
            Console.WriteLine("a -- "+a);
            Console.WriteLine("b --- "+b);



        }
    }
}
