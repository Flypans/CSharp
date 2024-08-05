using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Class Car 충돌 방지 됨
public class Car
{

}

namespace MeinAuto
{
    static public class Car
    {
        static public void Go() => Console.WriteLine("Yes MeinAuto.Car: Fahren");
    }
}

namespace DeinAuto
{
    public class Car
    {
        public void Go() => Console.WriteLine("No DeinAuto.Car: Parken");
    }
}
namespace NameSpaceTest
{
    public class Car
    {

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name Space");
            MeinAuto.Car.Go(); // Static member

            //DeinAuto.Car.Go();// Instance member Error!
            DeinAuto.Car car1 = new DeinAuto.Car();
            car1.Go();

            var car2 = new DeinAuto.Car();
            car2.Go();




        }
    }
}


