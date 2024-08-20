using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwaitTest
{
    class AsyncAwaitTest
    {
        //static void Main(string[] args)
        static async Task Main(string[] args)
        {
            await DoAsync();
        }
        static async Task DoAsync()
        {
            using(var client = new HttpClient())
            {
                //await
                var response =  await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
                var content = await response.Content.ReadAsStreamAsync();
                //var content = await response.Content.ReadAsStringAsync();

                Console.WriteLine(content);
            }
        }
    }
}
