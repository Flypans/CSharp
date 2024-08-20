using System;
using System.Threading.Tasks;

namespace AsyncAwaitTest3
{
    public class Steak
    {
        public async Task<Steak> MakeSteakAsync()
        {
            Console.WriteLine("Making Steak...");
            //await Task.Delay(3000);
            Parallel.For (0, 20_000, (i) => { Console.WriteLine($"{i}"); 
            });
            return new Steak();
        }
    }
}