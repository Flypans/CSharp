using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitTest3
{
    class Program
    {
        //public async Task<Steak> MakeSteakAsync()
        //{
        //    Console.WriteLine("Making Steak...");
        //    await Task.Delay(1000);
        //    return new Steak();
        //}

        //public async Task<Soup> MakeSoupAsync()
        //{
        //    Console.WriteLine("Making Soup...");
        //    await Task.Delay(1000);
        //    return new Soup();
        //}

        //public async Task<Egg> MakeEggAsync()
        //{
        //    Console.WriteLine("Making Egg...");
        //    await Task.Delay(TimeSpan.FromMilliseconds(1000));
        //    return await Task.FromResult<Egg>( new Egg());
        //}

        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            //DateTime start = DateTime.Now;
            stopwatch.Start();

            Steak steak = await (new Steak()).MakeSteakAsync();
            Console.WriteLine($"Steak {steak.GetHashCode()}");
            Console.Write("Async ...In Put:");
            Console.Read();
            Soup soup = await (new Soup()).MakeSoupAsync();
            Console.WriteLine($"Soup {soup.GetHashCode()}");

            Egg egg = await (new Egg()).MakeEggAsync();
            Console.WriteLine($"Egg {egg.GetHashCode()}");
            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds} ms");

            


        }
    }

}
