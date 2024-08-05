using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class DelegateSample
    {
        static void GoForward() => Console.WriteLine("geradeaus");
        delegate void CarDriver(); // declaring a Delegate

        static void GoLeft() => Console.WriteLine("Nach links");
        static void GoRight() => Console.WriteLine("Nach rechts");
        static void GoFast() => Console.WriteLine("Übergeschwindigkeit");

        static void RunLambda(Action action) => action();

        static void Main(string[] args)
        {
            //GoForward();

            /*            
                        CarDriver goHome = new CarDriver(GoForward);// call GoForward Method
                        goHome.Invoke();
                        goHome();//Invoke Dispensable
            */
            CarDriver goHome = GoForward;          
            goHome += GoLeft;
            goHome += GoRight;
            goHome += GoFast;
            goHome -= GoFast;
            goHome += delegate () { Console.WriteLine("STOP"); };
            goHome += delegate { Console.WriteLine("backward"); };
            
            //Lambda
            goHome += () => Console.WriteLine("Backward");

            goHome();

            //Create a Delegate Object directly through the built-in Delegate class format: Func<T>, Action<T>, Predicate<T>,...
            Action driver = GoForward;
            driver += GoLeft;
            driver += () => Console.WriteLine("STOP");
            driver(); //Delegate Call

            Action go = () => Console.WriteLine("Drive");
            go();

            RunLambda(() => Console.WriteLine("Pass a lambda expression as a parameter"));

            //numbers.Where(Func<>)
            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
