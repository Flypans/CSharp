using System;
using System.Diagnostics;
using System.Reflection;

namespace AttributeTest
{
    public class LuxuryAttribute : Attribute
    {
        public LuxuryAttribute()
        {
            Console.WriteLine("Kabiolett");
        }
    }
    [Luxury]
    //[LuxuryAttribute]

    class Car
    {
        //[Obsolete]
        [Obsolete("Manual will be removed from the next release version, so please use AutoGang.")]
        public void Manual() => Console.WriteLine("Manual Gear ");
        public void AutoGang() => Console.WriteLine("Auto Gear");

        [Conditional("DEBUG")]
        public void TestDrive() => Console.WriteLine("Test Drive");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Manual();
            car.AutoGang();
            car.TestDrive(); // does not operate in Release mode.

            //Attribute
            Attribute.GetCustomAttributes(typeof(Car));
            typeof(Car).GetCustomAttributes(false);

            //Reflection
            //Car carType = new Car();
            var carType = (new Car());

            Type myCar = carType.GetType();
            MethodInfo info = myCar.GetMethod("AutoGang");

            //info.Invoke(carType, null); //System.NullReferenceException:
            if (info != null)
            {
                info.Invoke(carType, null);
            }
            else
            {
                Console.WriteLine("The method 'AutoGang' does not exist on the type 'Car'.");
            }
        }
    }
}
