using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());
            if (x > 1)
                Console.WriteLine($"y={(1 - x) ^ 2}");
            else
            {
                if (x < 1)
                    Console.WriteLine($"y={x ^ 2}");
                else
                    Console.WriteLine($"y={0}");
            }
        }
    }
}
