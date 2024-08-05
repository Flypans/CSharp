using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorTest
{
    class Car
    {
        private string name;
        public Car() => Console.WriteLine("1_Creating an Object: Constructor");

        public Car(string name)
        {
            this.name = name;
            Console.WriteLine($"1_Creating an Object: Constructor {this.name}");
        }

        public void Go() => Console.WriteLine("2_Using the Object: Call");
        
        ~Car()
        {
            Console.WriteLine($"3_Object Destruction: Destructor{this.name}");      
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Go();

            Car car2 = new Car("Meins Autos");
            car2.Go();
        }
    }
}
