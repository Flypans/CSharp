using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public interface IStandard
    {
        void AirBag();// only signature 
    }
    public abstract class DeutschlandStandard
    {
        public abstract void SerialNumber();
        public void StandortFabrik() => Console.WriteLine("Stuttgart");
    }
    public partial class MyCar : DeutschlandStandard
    {
        public override void SerialNumber()
        {
            Console.WriteLine("Deutschland Serial Number:");
        }
    }
    public partial class MyCar : DeutschlandStandard, IStandard
    {
        public void AirBag()
        {
            Console.WriteLine("ISO 12097-1:2002");
        }

        public void Hazards() => Console.WriteLine("hazard warning lights");
    }
    public sealed class Car: MyCar
    {
        public void Go() => Console.WriteLine("Go ahead");
    }
/*
    class SpyCar : Car
    {
          
    }
*/
    public class InterfaceTest
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Go();
            /*
                        SpyCar spy = new SpyCar();
                        spy.Go();
            */
            car.Hazards();
            car.SerialNumber();
            car.AirBag();
            car.StandortFabrik();
        }
    }
}
