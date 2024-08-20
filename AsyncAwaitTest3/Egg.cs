using System;
using System.Threading.Tasks;

namespace AsyncAwaitTest3
{
    public class Egg
    {
        public async Task<Egg> MakeEggAsync()
        {
            Console.WriteLine("Making Egg...");
            await Task.Delay(TimeSpan.FromMilliseconds(3000));
            return await Task.FromResult<Egg>(new Egg());
        }
    }
}