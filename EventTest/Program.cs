using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{

    //Event Subscriber
    class EventAndDelegate
    {
        static void Main(string[] args)
        {
            EventAndDelegateCar car = new EventAndDelegateCar();
            car.LackOfFuel += Car_LackOfFuel;
            car.LackOfFuel += () =>
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.BackgroundColor = System.ConsoleColor.Blue;
                System.Console.WriteLine("Fill the car with gas");
                System.Console.ResetColor();
            };

            car.Go();
            //car.IlluminateLackOfFuel();
            car.Go();
        }

        //Event Handler
        private static void Car_LackOfFuel()
        {
            System.Console.WriteLine(" Lack of Fuel !");
        }
    }
}
