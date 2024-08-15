using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string staticString = "Hallo";
            var staticVar = "World";
            dynamic dynamicString = "12345";

            Console.WriteLine($"{staticString.ToUpper()}:{staticString.GetType()}");
            Console.WriteLine($"{staticVar.ToLower()}:{staticVar.GetType()}");
            //Console.WriteLine($"{dynamicString.Length()}:{dynamicString.GetType()}");//Runtime Error
            Console.WriteLine($"{dynamicString} : {dynamicString.GetType()}");
        }
    }
}
