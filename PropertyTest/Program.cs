using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    class Car
    {
        public string name;// Field , C#1.0 This code should not be exposed externally. 
    }

    class Car1
    {
        private string name;// Field , C#1.0
        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

    }

    class Car2
    {
        private string name;// Field , C#1.0
        public string Name //Property , Method 아님
        {
            get 
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }
    }

    class Car3
    {
        public string Name { get; set; }
    }

    class Car4
    {
        public string Name { get; set; }
    }

    class Car5
    {
        public string Name { get; set; } = "My Auto";
    }

    class Car6
    {
        public string Name { get; private set; } = "My Auto too";
    }

    class Car7
    {
        public string Name { get; set; } = "My Ball";
    }
    class Program
    {
        public static object Name { get; private set; }

        static void Main(string[] args)
        {
            Car car = new Car();
            car.name = "Mein Auto";
            Console.WriteLine(car.name);

            Car1 car1 = new Car1();
            car1.SetName("Dein Auto");
            Console.WriteLine(car1.GetName());

            Car2 car2 = new Car2();
            car2.Name = "Ihrem Auto";
            Console.WriteLine(car2.Name);

            Car3 car3 = new Car3();
            car3.Name = "keiner";
            Console.WriteLine(car3.Name);

            Car4 car4 = new Car4() { Name = "Object Initializer" };
            Console.WriteLine(car4.Name);

            Car5 car5 = new Car5();
            Console.WriteLine(car5.Name);

            //Console.WriteLine((new Car6()).Name);
            Car6 car6 = new Car6();
            //car6.Name = "My Car";// The property 'Car6.Name' cannot be used in this context because the set accessor is inaccessible PropertyTest
            Console.WriteLine(car6.Name);

            //익명형식
            var person = new { Name = "Müller", Age = 32 };
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            //Car7 car7 = new Car7();
            //Console.WriteLine(car7.Name);

            Car7 car7 = new Car7{ Name = null};
            Console.WriteLine(car7.Name);
            Console.WriteLine(car7?.Name);
            Console.WriteLine(car7?.Name?? "Geisterauto");
        }
    }
}
