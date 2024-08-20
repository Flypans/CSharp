using System;
using System.Threading.Tasks;

namespace AsyncAwaitTest3
{
    public class Soup
    {
        public async Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("Making Soup...");
            await Task.Delay(3000);
            return new Soup();
        }
    }

}