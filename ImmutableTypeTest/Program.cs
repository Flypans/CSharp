using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableTypeTest
{
    public class Circle
    {
        public int Radius { get; private set; } = 0;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public Circle MakeNue(int radius) => new Circle(radius);// Initialize only as a constructor

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine($"Radius: {circle.Radius} - {circle.GetHashCode()}");

            circle = circle.MakeNue(20);
            //circle.Radius = 30; //set accessor is inaccessible
            Console.WriteLine($"Radius: {circle.Radius} - {circle.GetHashCode()}");

        }
    }
}
