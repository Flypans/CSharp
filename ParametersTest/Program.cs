using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Type
            string TypeValue = "Value copy";
            Console.WriteLine($"1_title: {TypeValue}");
           
            var car = new Car();
            car.MapValue(TypeValue);
            Console.WriteLine($"3_title: {TypeValue}");

            //Referance Type 
            string TypeReferance = "Referance Arrow";
            Console.WriteLine($"1_title: {TypeReferance}");

            var car2 = new Car();
            car2.MapRef(ref TypeReferance);
            Console.WriteLine($"3_title: {TypeReferance}");

            //Output Parameters
            string TypeOutput;
            //Console.WriteLine($"1_title: {TypeOutput}");

            var car3 = new Car();
            car3.MapOut(out TypeOutput);
            Console.WriteLine($"3_title: {TypeOutput}");

            //Params Array
            var car4 = new Car();
            car4.MapParams("Benz", "BMW", "Audi", "VW");

            //optional parameter
            var car5 = new Car();
            car5.MapOptional("Car");
            car5.MapOptional(" This", " is" , " Yours");

            //named parameter
            car.MapOptional(prefix: "This car ", suffix: " me", message: " belongs to");
        }

    }
}