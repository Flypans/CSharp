using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitTest4
{
    public class Steak
    {
        public async Task<Steak> MakeSteakAsync()
        {
            Console.WriteLine("Making Steak...");
            await Task.Delay(3000);
            return new Steak();
        }
    }
    public class Soup
    {
        public async Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("Making Soup...");
            await Task.Delay(3000);
            return new Soup();
        }
    }
    public class Egg
    {
        public async Task<Egg> MakeEggAsync()
        {
            Console.WriteLine("Making Egg...");
            await Task.Delay(TimeSpan.FromMilliseconds(3000));
            return await Task.FromResult<Egg>(new Egg());
        }
    }


    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Choose a number from 0 to 4");
            Console.WriteLine("0. Sync\t1. await\t2. Task<T>\t 3. WhenAll\t 4. WhenAny");
            Console.Write("Number: ");

            var number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 0: //Sync 비동기 순차 실행
                    {
                        Console.WriteLine($" Your Chose Sync");
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        Steak steak = new Steak();
                        steak.MakeSteakAsync();
                        Console.WriteLine($"Making...Steak - {steak.GetHashCode()}");

                        Soup soup = new Soup();
                        soup.MakeSoupAsync();
                        Console.WriteLine($"Making...Steak - {soup.GetHashCode()}");

                        Egg egg = new Egg();
                        egg.MakeEggAsync();
                        Console.WriteLine($"Making...Steak - {egg.GetHashCode()}");

                        stopwatch.Stop();
                        Console.WriteLine($"End Time: {stopwatch.ElapsedMilliseconds} ms");
                        Console.WriteLine("Sync End");
                        break;
                    }


                case 1://Async //순차 실행
                    {
                        Console.WriteLine($" Your Chose await");
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        Steak steak = new Steak();
                        await steak.MakeSteakAsync();
                        Console.WriteLine($"Making...Steak - {steak.GetHashCode()}");

                        Soup soup = new Soup();
                        await soup.MakeSoupAsync();
                        Console.WriteLine($"Making...Steak - {soup.GetHashCode()}");

                        Egg egg = new Egg();
                        await egg.MakeEggAsync();
                        Console.WriteLine($"Making...Steak - {egg.GetHashCode()}");

                        stopwatch.Stop();
                        Console.WriteLine($"End Time: {stopwatch.ElapsedMilliseconds} ms");
                        Console.WriteLine("Sync End");
                        break;
                    }
                case 2:// Async //동시 실행 Task<Steak> steakTask ,  Steak steak = await steakTask;
                    {
                        Console.WriteLine($" Your Chose Task<T>");
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        //Steak steak = await(new Steak()).MakeSteakAsync();
                        //Soup soup = await(new Soup()).MakeSoupAsync();
                        //Egg egg = await (new Egg().MakeEggAsync() );
                        Task<Steak> steakTask = (new Steak()).MakeSteakAsync();
                        Task<Soup> soupTask = (new Soup()).MakeSoupAsync();
                        Task<Egg> eggTask = (new Egg().MakeEggAsync());

                        Steak steak = await steakTask;
                        Console.WriteLine($"Finish...Steak - {steak.GetHashCode()}");

                        Soup soup = await soupTask;
                        Console.WriteLine($"Finish...Steak - {soup.GetHashCode()}");

                        Egg egg = await eggTask;
                        Console.WriteLine($"Finish...Steak - {egg.GetHashCode()}");

                        stopwatch.Stop();
                        Console.WriteLine($"End Time: {stopwatch.ElapsedMilliseconds} ms");
                        Console.WriteLine("Sync End");
                        break;
                    }

                case 3:// Async 모두 완료되는 시점까지 
                    {
                        Console.WriteLine($" Your Chose  WhenAll");
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        Task<Steak> steakTask = (new Steak()).MakeSteakAsync();
                        Task<Soup> soupTask = (new Soup()).MakeSoupAsync();
                        Task<Egg> eggTask = (new Egg().MakeEggAsync());

                        await Task.WhenAll(steakTask, soupTask, eggTask);

                        stopwatch.Stop();
                        Console.WriteLine($"End Time: {stopwatch.ElapsedMilliseconds} ms");
                        Console.WriteLine("Sync End");
                        break;
                    }

                case 4:// Async 하나만이라도 끝나면
                    {
                        Console.WriteLine($" Your Chose  WhenAny");
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        Task<Steak> steakTask = (new Steak()).MakeSteakAsync();
                        Task<Soup> soupTask = (new Soup()).MakeSoupAsync();
                        Task<Egg> eggTask = (new Egg().MakeEggAsync());

                        var allTasks = new List<Task> { steakTask, soupTask, eggTask };
                        try
                        {
                            while (allTasks.Any())
                            {
                                Task finished = await Task.WhenAny(allTasks);

                                if (finished == steakTask)
                                {
                                    Steak steak = await steakTask;
                                    Console.WriteLine($"End ... Steak-{steak}");
                                }
                                else if (finished == soupTask)
                                {
                                    Soup soup = await soupTask;
                                    Console.WriteLine($"End ... Soup-{soup}");
                                }
                                else if (finished == eggTask)
                                {
                                    Egg egg = await eggTask;
                                    Console.WriteLine($"End ... Egg-{egg}");
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                }
                                allTasks.Remove(finished);//무한루프 리스트에서 제거
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occurred: {ex.Message}");
                        }
                        
                        stopwatch.Stop();
                        Console.WriteLine($"End Time: {stopwatch.ElapsedMilliseconds} ms");
                        Console.WriteLine("Sync End");
                        break;
                    }



                default:
                    Console.WriteLine($"Default sync");

                    break;
            }
        }
    }
}
