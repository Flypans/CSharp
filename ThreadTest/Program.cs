using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Restaurant
    { 
        public void MakeCooking()
        {
            Console.WriteLine($"Start Cooking");
            DateTime start = DateTime.Now;

            void Egg()
            {
                Thread.Sleep(3000);
                Console.WriteLine("Cooking Egg 3s");
            }
            void Soup()
            {
                Thread.Sleep(5000);
                Console.WriteLine("Cooking Soup 5s");
            }


            //Sync
            /*           
                        Egg();
                        Soup();
            */
            //Async
            Thread task1 = new Thread(new ThreadStart(Egg));
            Thread task2 = new Thread(Soup);
            Thread task3 = new Thread(() => { Thread.Sleep(5_000); Console.WriteLine("5 Sec"); });

            //async
            task1.Start();
            task2.Start();
            task3.Start();

            //await
            task1.Join();
            task2.Join();
            task3.Join();

            //SingleProcess();
            MultiProcess();

            Console.WriteLine($"Stop Cooking : {(DateTime.Now) - start}");
        }

        private void SingleProcess()
        {
            for (int i = 0; i < 10_000; i++)
            {
                Console.WriteLine("Waiting");
            }
        }

        private void MultiProcess()
        {

            Parallel.For(0, 10_000, (i) => { Console.WriteLine($"Waiting {i}"); });
         
        }

    }
    class ThreadTest
    {
        /*
                static void Main(string[] args)
                {
                    Restaurant restaurant = new Restaurant();
                    restaurant.MakeCooking();
                }
        */
        static void Main(string[] args) => (new Restaurant()).MakeCooking();
    }

}
