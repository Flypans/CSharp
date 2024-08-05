using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoofTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                      int n = 5;
                      int sum = 0;

                                  for(int i = 1; i <= n; i++)
                                  {
                                      if(i % 2 == 0)
                                      {
                                          sum += i;
                                      }
                                  }

                                  Console.WriteLine($"1 ~ {n} : sum of even number = {sum}");
                      */
            /*
                        string[] names = { "C#", ".NET" };

                        foreach (var item in names)
                        {
                            Console.WriteLine(item);
                        }
            */
            /*
                        string str = "ABCDEFGHIJKLMN";

                        foreach (char albabet in str)
                        {
                            Console.WriteLine(albabet);
                        }
             */

            //int numbers;
            //numbers[0];

            int[] numbers = new int[3];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[] numbers2 = new int[3] { 80, 90, 10 };
            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
