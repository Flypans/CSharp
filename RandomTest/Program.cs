using System;


namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1~100");

            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{random.Next(1, 11)}, ");
            }

            Console.WriteLine();
            Console.WriteLine("1~6");

            Random dice = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{dice.Next(1, 7)}, ");
            }

        }
    }
}
