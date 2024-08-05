using System;
using System.Collections;//C# 1.0
using System.Collections.Generic; //C#2.0
using System.Linq;

namespace CollectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            /*
                        string[] colors = { "red", "green", "blue" };

                        foreach (var color in colors)
                        {
                            Console.WriteLine(color);
                        }
                        Console.WriteLine();

                        Array.Sort(colors);
                        foreach (var color in colors)
                        {
                            Console.WriteLine(color);
                        }
                        Console.WriteLine();

                        Array.Reverse(colors);
                        foreach (var color in colors)
                        {
                            Console.WriteLine(color);
                        }
            */
            //Stack
            /*
                        Stack stack = new Stack();
                        stack.Push(100);
                        stack.Push(200);
                        Console.WriteLine(stack.Pop());
                        Console.WriteLine(stack.Pop());
                        Console.WriteLine(stack.Pop());
            */
            //Queue
            /*
                        Queue queue = new Queue();
                        queue.Enqueue(100);
                        queue.Enqueue(200);
                        Console.WriteLine(queue.Dequeue());
                        Console.WriteLine(queue.Dequeue());
                        Console.WriteLine(queue.Dequeue());
            */
            //List
            /*
                        ArrayList list = new ArrayList();
                        list.Add(100);
                        list.Add(100);
                        list.RemoveAt(1);
                        list.Add(200);
                        list.Insert(0, 50);
                        Console.WriteLine(list[0]);
                        Console.WriteLine(list[1]);
                        Console.WriteLine(list[2]);
                        Console.WriteLine(list[3]);
            */

            //HashTable
            /*
                        Hashtable hashtable = new Hashtable();
                        hashtable[0] = "C# DotNet";
                        hashtable["cSharp"] = "Micro Soft";
                        Console.WriteLine(hashtable[0]);
                        //Console.WriteLine(hashtable[1]);

                        Console.WriteLine(hashtable["cSharp"]);
            */
            /*
                        //using System.Collections;//C# 1.0
                        Stack stackBox = new Stack();
                        stackBox.Push(100);
                        Console.WriteLine(stackBox.Pop());
            */

            //Stack of T
            /*
                        Stack<int> stackNoBox = new Stack<int>();
                        stackNoBox.Push(200);
                        Console.WriteLine(stackNoBox.Pop());
            */


            //List of T
            /*
                        List<int> numbers = new List<int>();

                        //numbers.Add(10);
                        //numbers.Add(20);

                        numbers.AddRange(Enumerable.Range(1, 10 ));

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.WriteLine(numbers[i]);
                        }

                        foreach (var number in numbers)
                        {
                            Console.WriteLine(number);
                        }

                        List<string> colors = new List<string>();
                        colors.Add("Black");
                        colors.Add("Red");
                        colors.Insert(2, "Yello");

                        foreach (var color in colors)
                        {
                            Console.WriteLine(color);
                        }

                        var enumNumbers = Enumerable.Range(1, 10);

                        foreach (var enumNumber in enumNumbers)
                        {
                            Console.WriteLine(enumNumber);
                        }

                        var enumNumbersRepeats = Enumerable.Repeat(1, 10);

                        foreach (var enumNumbersRepeat in enumNumbersRepeats)
                        {
                            Console.WriteLine(enumNumbersRepeat);
                        }
            */
            // Dictionary of T
            Dictionary<int, string> toDos = new Dictionary<int, string>();
            toDos.Add(1, "C#");
            toDos.Add(2, "WPF");
            toDos.Add(3, "Algorithum");
            toDos.Add(4, ".NET Core");

            foreach (var dict in toDos)
            {
                Console.WriteLine($"{dict.Key} - {dict.Value}");
            }
            
        }
    }
}
