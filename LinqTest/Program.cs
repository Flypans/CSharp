using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {

            /*          
                        int sum = 0;

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
            */

            int[] numbers = { 1, 2, 3 };
/*
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
*/
            numbers.ToList().ForEach(number => Console.WriteLine(number));


            Console.WriteLine( $" Sum = {numbers.Sum()}");
            Console.WriteLine( $" Max = {numbers.Max()}");
            Console.WriteLine( $" Min = {numbers.Min()}");
            Console.WriteLine( $" AVG = {numbers.Average()}");
            Console.WriteLine( $" Count = {numbers.Count()}");
            

            int[] numbers2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numberList = new List<int>(numbers2);

            var result = numbers2.Select(x => x);
            Console.WriteLine("{" + string.Join(", ", result) + "}");

            var evenNumbers = numberList.Where(n => n % 2 == 0);

            //foreach (var i in evenNumbers)
            //{
            //    Console.WriteLine(i);
            //}

            evenNumbers.ToList().ForEach(n => Console.WriteLine(n));//Lambda

            numbers.Where(n => n % 2 == 0);

            int[] numbers3 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers3.Max());

            var result3 = numbers3.Where(n => n % 2 == 0);
            Console.WriteLine("{"+ string.Join(", ", result3) +"}");

            var result4 = numbers3.Where(n => n % 2 == 0).Max();
            Console.WriteLine(result4);

            IEnumerable<int> newNumbers = numbers.Where(n => n % 2 == 0 || n % 3 == 0);
                        newNumbers.ToList().ForEach(n => Console.WriteLine(n));

            List<string> csTech = new List<string>();
            csTech.Add("C#");
            csTech.Add(".Net");
            csTech.Add("Blazor");

            csTech.ForEach(n => Console.WriteLine(n));
            var sortedcsTech = csTech.OrderBy(x => x);
            sortedcsTech.ToList().ForEach(n => Console.WriteLine(n));

            sortedcsTech = csTech.OrderByDescending(x => x);
            sortedcsTech.ToList().ForEach(n => Console.WriteLine(n));

            var numbers4 = Enumerable.Range(1, 100);
            numbers4.ToList().ForEach(n => Console.WriteLine(n));

            var sortedNumber = numbers4.OrderByDescending(x => x);
            sortedNumber.ToList().ForEach(n => Console.WriteLine(n));

            numbers4.Where(n => n % 2 == 0).ToList().ForEach(n => Console.WriteLine(n));
            
            var DeSortedNumbers = numbers4.Where(n => n % 2 == 0).OrderByDescending(n => n).ToList();
            DeSortedNumbers.ForEach(n => Console.WriteLine(n));

            //Query syntex
            //var q = from n in numbers4;
            //        where n % 2 == 0;
            //        select n;

            //methord syntex
            var qq = numbers4.Where(n => n % 2 == 0);
            qq.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
