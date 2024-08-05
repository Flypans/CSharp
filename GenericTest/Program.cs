using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace GenericTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = 1_000_000;

            //NonGenericStack
            Stack stackBox = new Stack();

            //GenericStack
            Stack<int> stackNoBox = new Stack<int>();
            
            Console.WriteLine("Test 1:");
            Stopwatch NonGenericStack = Stopwatch.StartNew();

            for (int i = 0; i < iterations; i++)
            {
                stackBox.Push(i);
            }

            NonGenericStack.Stop();
            Console.WriteLine($"NonGenericStack push time: {NonGenericStack.ElapsedMilliseconds} ms");

            Console.WriteLine("Test 2:");
            Stopwatch GenericStack = Stopwatch.StartNew();

            for (int i = 0; i < iterations; i++)
            {
                stackNoBox.Push(i);
            }
            GenericStack.Stop();
            Console.WriteLine($"GenericStack push time: {GenericStack.ElapsedMilliseconds} ms");


        }
    }
}
