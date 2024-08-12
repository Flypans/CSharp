using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsOOPTest
{
    class CsOOPTest
    {


        public class OverLoadsMethod
        {
            // Valid overloads: Different parameter lists
            public void Angestelter(int AngestelterNumber) { }

            //Error CS0111:  Type already defines a member called 'Angestelter' with the same parameter types CsOOPTest
            //public void Angestelter(int AngestelterAge) { }
            public void Angestelter(int AngestelterNumber, string AngestelterRaum) { }

            public void Angestelter(string AngesterName) { }

            //Error CS0161: not all code paths return a value
            //public int Angestelter(string AngestelterRaum) { }
        }

        static int OutParametrs(out int price)
        {
            //내부에서 반드시 초기화되어야 하며
            // 본문이 비어 있어 price를 초기화하지 않고 있습니다.따라서 이 상태로 컴파일하면 오류가 발생
            //Error CS0177  The out parameter 'price' must be assigned to before control leaves the current method
            price = 30;
            return price;
        }

        static void ExamOutParametrs()
        {
            int MyPercent;
            OutParametrs(out MyPercent);
            Console.WriteLine($"The value of My percent is: {MyPercent}");
        }

        static long AddList(params long[] viele)
        {
            long total = 0;

            for (int i = 0; i < viele.Length; i++)
            {
                total += viele[i];
            }
            return total;
        }



        static void Main(string[] args)
        {

            //Tower of Hanoi
            int FactorialRecursion(int n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                return n * FactorialRecursion(n - 1);
            }
            Console.WriteLine(FactorialRecursion(5));


            //Fibonacci sequence
            int FactorialIterative(int n)
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
            Console.WriteLine(FactorialIterative(5));

            //Stack 클래스 LIFO 구조

            Stack stack = new Stack();

            stack.Push(100);
            stack.Push(200);
            stack.Push(300);


            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine($"Pop: {stack.Pop()}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


            //Queue 클래스 FIFO 구조
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Dequeue: {queue.Dequeue()}");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //ArrayList 클래스  LIFO + FIFO구조
            ArrayList list = new ArrayList();
            list.Add(100);
            list.Add(1000);
            list.RemoveAt(1);
            list.Add(200);
            list.Insert(0, 50);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Dictionary
            Dictionary<int, string> toDos = new Dictionary<int, string>();
            toDos.Add(1, "C#");
            toDos.Add(2, "WPF");
            toDos.Add(3, "Dotnet");

            foreach (var item in toDos)
            {
                Console.WriteLine(item);
            }

            //HashTable
            Hashtable hashtable = new Hashtable();
            hashtable[0] = "C# DotNet"; // Key, Value
            hashtable["cSharp"] = "Micro Soft";//Key, Value
            hashtable[2] = "WPF";

            foreach (DictionaryEntry entry in hashtable)
            {
                //Console.WriteLine(item);
                Console.WriteLine($"Key:{entry.Key}, Value:{entry.Value}");
            }
            //Hashtable의 요소 순서가 추가된 순서와 다를 수 있는 이유는 Hashtable이 본질적으로 순서가 없는 컬렉션이기 때문입니다.
            //요소의 순서는 키의 해시 코드와 Hashtable의 내부 구조에 따라 결정되며, 이는 요소의 특정 순서를 보장하지 않습니다.

            var numbers = new[] { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            var enumNumbers = Enumerable.Range(1, 10);
            foreach (var item in enumNumbers)
            {
                Console.WriteLine(item);
            }


            int[] numbers2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("1------------------------------");
            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }

            // LINQ의 Select 메서드를 사용하여 numbers2 배열의 각 요소를 그대로 선택합니다.
            // Select 메서드는 배열의 각 요소를 입력으로 받아 원하는 변환을 수행할 수 있게 해주지만,
            // 여기서는 변환 없이 각 요소를 그대로 반환합니다. 결과적으로 result2는 numbers2와 동일한 요소를 갖는 IEnumerable<int> 가 됩니다.
            Console.WriteLine("2------------------------------");
            var result2 = numbers2.Select(x => x);
            Console.WriteLine("{" + string.Join(",", numbers2) + "}");

            Console.WriteLine("3------------------------------");
            numbers2.ToList().ForEach(x => Console.WriteLine(x));

            ExamOutParametrs();
            long xPrice = AddList(25, 30, 15);
            Console.WriteLine($"Total Price:  {xPrice} Euro ");


        }

    }

}
