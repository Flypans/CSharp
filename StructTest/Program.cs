using System;
using static System.Math;


namespace StructTest
{
    public struct Employee
    {
        public string Name;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee companyEmployee;
            companyEmployee.Name = "John";
            companyEmployee.Age = 44;

            Console.WriteLine(companyEmployee.Name);
            Console.WriteLine(companyEmployee.Age);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Millisecond);

            TimeSpan ts =(DateTime.Now - (new DateTime(1999, 12, 31)));
            Console.WriteLine(ts.TotalDays);

            Console.WriteLine(Math.Ceiling((DateTime.Now - (new DateTime(2024, 1, 1))).TotalDays));

            Console.WriteLine(Char.ToUpper('a'));
            Console.WriteLine(Char.IsWhiteSpace(' '));
            Console.WriteLine(Char.IsWhiteSpace('A'));
            Console.WriteLine(Char.IsDigit('1'));
            Console.WriteLine(Char.IsDigit('A'));
            Console.WriteLine(Char.IsLetterOrDigit('!'));

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Guid.NewGuid());
            }

        }
    }
}
