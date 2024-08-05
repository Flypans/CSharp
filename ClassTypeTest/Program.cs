using System;


namespace ClassTypeTest
{
    class Square
    {
        public int Width;
        public int Height;
        public static string Creator;
    }
    class Program
    {
        static void Main()
        {
            Square square = new Square();
            square.Height = 200;
            square.Width = 100;
            Square.Creator = "DongDong";
            Console.WriteLine($"{square.Height}, {square.Width}, {Square.Creator}");
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.Version);

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(1, 7));

            string s = "Test";
            object x = 1234;
            Console.WriteLine(typeof(object));

            s = x as string;
            Console.WriteLine($"{s}");

            string z = "Exam";
            object y = "1234";
            Console.WriteLine(typeof(object));

            z = y as string;
            Console.WriteLine($"{z}");

            if (s is string)
            {
                Console.WriteLine("String");
            }
            else
            {
                Console.WriteLine("Not String");
            }

            if (x is object)
            {
                Console.WriteLine("object");
            }
            else
            {
                Console.WriteLine("Not Object");
            }
        }
    }
}
