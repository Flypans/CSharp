using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTest
{   
    public class Person
    {
        private string name = "havertz";
        private const int number = 7; //Field , Member Variable, GV
        private readonly string nickName ;
        private string[] premierLeague = { "Chelsea ", "Arsenal" };

        public Person()
        {
            nickName = "Alleskonner";
        }
        public void ShowProfile()
        {
            Console.Write($" {name}, {number}, {nickName},");
            premierLeague.ToList().ForEach(x => Console.Write(x));
        }
    }
    public class Car
    {
        //private string color = "Rot";// protection level
        public string color1 = "Rot";
        private string color2 = "Schwarz";

        //public string GetColor2() => color2;
        public string GetColor2()
        {
            return this.color2;
        }
    }
    public class Say
    {
        private string message = "Hello"; // Field

        public void Hallo() => Console.WriteLine(this.message); // this 는 나 자신의 Instance
    }
    public class Program
    {
        private static string message = "Hallo";// Field, ~ Global Variable
        //private  string message = "Hallo";

        public static void Hallo() => Console.WriteLine($"Hallo {message}");

        public static void Main(string[] args)
        {
            int number = 1_234;// local variable
            Console.WriteLine(number);
/*            
            Program smessage = new Program(); // Instance 생성
            Console.WriteLine(smessage.message);
*/
            Console.WriteLine($"Main {message}");//non-static field는 호출 할 수 없다. Instance member
            Hallo();

            Say say = new Say();
            say.Hallo();

            Car car = new Car();
            Console.WriteLine(car.color1);
            Console.WriteLine(car.GetColor2());

            Person person = new Person();
            person.ShowProfile();

        }
    }
}
