using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitTest2
{
    class AsyncAwaitTest2
    {
        static async Task Main(string[] args)//async Task
        {
            //SyncMethodTest();
             await AsyncMethodTest();//await
            Console.WriteLine("Please any Key to exit !!!");
            Console.ReadLine();
        }

        private static async Task AsyncMethodTest()
        {
            await LongtimeAsyncMethod();
        }

        private static async Task<int> LongtimeAsyncMethod()
        {
            Console.WriteLine("Long Time...Start");
            await Task.Delay(3000);
            Console.WriteLine("Long Time...End");
            return 1;
        }
/*
        private static void SyncMethodTest()
        {
            Console.WriteLine("Long Time...Start");
            Thread.Sleep(3000);
            Console.WriteLine("Long Time...End");
        }
*/
    }
}
