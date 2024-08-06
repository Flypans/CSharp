using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadTest
{
    public class Car
    {
        public string Name { get; private set; }
        public Car(string name) => Name = name;

        //변환연산자 구현
        public static implicit operator Car(string name)=> new Car(name);//Resend to the constructor , 생성자 재정의
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("My Car");
            Console.WriteLine($"{car.Name}");

            //car.Name = "Dein Auto"; //Error

            Car car1 = "String is passed directly to the constructor";
            Console.WriteLine(car1.Name);


            Car car2 = "Mein Auto";// Operator Overload
            Console.WriteLine($"{car2.Name}");
        }
    }
}
