using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncAsyncTest
{
    class SyncAsyncTest
    {

        static void Main(string[] args)
        {
            Task.Run(() => DoPrint());
            Console.WriteLine("async/await 1");
            Thread.Sleep(1);
        }
        //static async Task Main(string[] args)
        //{
        //    //PrintNumber();
        //    await PrintNumberAsync();
        //    Console.WriteLine("Process 1");
        //}


        /*
                static void Main(string[] args)
                {
                    PrintNumber();
                    Console.WriteLine("Process 1");
                }
                static void PrintNumber()
                {
                    for (int i = 0; i < 30; i++)
                    {
                        Console.WriteLine(i + 1);
                    }
                }
             */
        static async void DoPrint()
        {
            await PrintNumberAsync();
        }
        static async Task PrintNumberAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i + 1);
                }
            });
        }
    }
}
