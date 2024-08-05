using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorTest
{
    public class Car
    {
        //private string AutoName; //Field
        private readonly string name; //Field

        // no void, no return
        public Car() : this("Default Constructor Forwarding") // Default Constructor, Constructor Method
        {
            Console.WriteLine("Car Object, Instance, Constructor");
        }

        public Car(string name)
        {
            this.name = name;//  this.name: Field, name: argument
        }
        public void Go() => Console.WriteLine($"{name} Abfahren."); // name: Field


    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Go();

            Car myCar = new Car("Meines Autos Porsche");
            myCar.Go();
        }
    }
}
