using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    public enum CarType { ICE, EV, Hybrid } //Internal Combustion Engin, Electric Vehicle

    // public class MadeIn
    public abstract class MadeIn
    {
        public abstract void CarInsurance();

        //public string KundenNumber  { get; set; } = "Germany_2024_247";
        //protected string KundenNumber  { get; set; } = "Germany_2024_247";
        //protected string KundenNumber { get; set; } = "Germany_2023_247";// visible only to derived classes
        protected string KundenNumber { get; private set; } = "Germany_2023_247";// visible only to derived classes

        public MadeIn() => Console.WriteLine("Made In Deutschland");

    }
    public class Car : MadeIn
    {
        public CarType Style { get; private set; }
        public Car(CarType carType)
        {
            this.Style = carType;
        }
        //public override void CarInsurance() => Console.WriteLine("Allianz");
        public override void CarInsurance()
        {
            Console.WriteLine(base.KundenNumber);
            //base.KundenNumber = "USA_2024_001";
            //Console.WriteLine($"base.KundenNumber: {base.KundenNumber}");
            Console.WriteLine($"KundenNumber: {KundenNumber}");


        }
        /*
                public override void CarInsurance()
                {
                    throw new NotImplementedException();
                }
        */
        public void Go() => Console.WriteLine("Drive.");



    }

    public class Benz : Car //Sub
    {

        //public CarType Style { get; private set; }

        public Benz() : this(CarType.ICE)
        {
            //Style = CarType.ICE;
        }

        public Benz(CarType carType) : base(carType)
        {
            //this.Style = carType;
        }

    }

    public class BMW : Car //Child
    {
        //public CarType Style { get; set; } = CarType.EV;

        public BMW() : this(CarType.EV)
        {

        }

        public BMW(CarType carType) : base(CarType.Hybrid)
        {

        }
    }

    //public class Future : Car
    public sealed class Future : Car
    {
        public Future() : this(CarType.EV) // 기본 생성자
        {

        }
        public Future(CarType carType) : base(carType)
        {
        }

        public new void Go() //Override
        {
            base.Go();// 부모의 Go
            Console.WriteLine("Override"); //추가 Override virtual override -> Hiding new

        }
    }

    /*
        public class OtherFuture : Future // with Sealed Error CS0509'OtherFuture': cannot derive from sealed type 'Future'
        {

        }
    */
    class Program : Object
    {

        static void Main(string[] args)
        {

            /*
                        Car car = new Car();
                        (new Benz()).Go();
                        (new BMW()).Go();
            */
            Benz benz = new Benz();
            benz.Go();
            Console.WriteLine($"{benz.Style}");
            benz.CarInsurance();

            Benz benz1 = new Benz(CarType.Hybrid);
            Console.WriteLine($"{benz1.Style}");

            BMW bmw = new BMW();
            bmw.Go();
            Console.WriteLine($"{bmw.Style}");
            bmw.CarInsurance();

            Future future = new Future();
            future.Go();
            /*
                        OtherFuture otherFuture = new OtherFuture();
                        future.Go();
            */
        }
    }
}
