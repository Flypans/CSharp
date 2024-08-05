using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest
{
    public class AutoOne
    {
        public static void Hallo() => Console.WriteLine("Hi");
    }

    public class AutoTwo
    {
        public void Hallo() => Console.WriteLine("Moing");
    }
    public class ClassCode
    {
        public void Execute()
        {
            int hashCode = this.GetHashCode();
            Console.WriteLine($"classCode: {hashCode}");
        }

    }

    public class Car
    {
        public void Go() => Console.WriteLine($"Fahren {this.GetHashCode()}");
        public override string ToString() => "Mein Auto"; //재정의 
  
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        ClassCode classCode1 = new ClassCode();
                        classCode1.Execute();

                        ClassCode classCode2 = new ClassCode();
                        classCode2.Execute();
            */

            /*
            Car car1 = new Car();
            Car car2 = new Car();
            var car3 = new Car();
            Car car = new Car();

                        car1.Go();
                        car2.Go();
                        car3.Go();
                        Console.WriteLine(car);//ObjectTest.Car
                        Console.WriteLine(car.ToString()); 
            */
            AutoOne.Hallo();// Static Mathod

            //AutoTwo.Hallo();//Non-Static field, Instance Mathod
            AutoTwo zwei = new AutoTwo();
            zwei.Hallo();
        }
    }
}
