using System;

namespace Mod7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int mod = input % 7;
            int result;
            if (mod > 3)
            {
                result = input + 7 - mod;
                Console.WriteLine("\nNearest number:\n" + result);
            }
            else if (mod == 0)
            {
                Console.WriteLine("\nEntered number is divisible by seven");
            }
            else
            {
                result = input - mod;
                Console.WriteLine("\nNearest number:\n" + result);
            }
        }
    }
}
