using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {

        //static int FactorialIterative(int n)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        static int Factorial(int n)
        {
            if( n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            int factorialSum = 0 ;
            factorialSum = Factorial(5);
            Console.WriteLine($"5! = {factorialSum}");

            //FactorialIterative(5);
        }
    }
}
