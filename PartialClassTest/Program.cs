using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassTest
{
    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class Person
    {
        public void Printer() => System.Console.WriteLine($"name: {Name}, Age: {Age}");
    }
    class PartialClassMain
    {
        static void Main(string[] args)
        {
            var hello = new Hello();
            hello.Hi();
            hello.Bye();

            Person person = new Person();
            person.Name = "C#";
            person.Age = 24;

            person.Printer();

        }
    }
}
