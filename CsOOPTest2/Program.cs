using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsOOPTest2
{
    class CsOOPTest2
    {
        // Define a delegate type
        public delegate void EventHandler(object sender, EventArgs e);//Event Delegate
        public delegate void Callback(string message); //Callback Delegate
        public delegate void MultiDelegate();// Multicast Delegate 
        public delegate void CarDriver();

        // Define methods that match the delegate signature
        public static void GoForward() => Console.WriteLine("5.geradeaus");
        public static void GoLeft() => Console.WriteLine("5.Nach links");
        public static void GoRight() => Console.WriteLine("5.Nach rechts");
        public static void GoFast() => Console.WriteLine("5.Übergeschwindigkeit");

        public static void Method3() { Console.WriteLine($"5.Method3: "); }
        public static void Method4() => Console.WriteLine($"5.Method4: ");

        public class Button
        {
            public event EventHandler Click;

            public void OnClick()
            {
                if (Click != null)
                {
                    Click(this, EventArgs.Empty);
                }
            }
        }
        public static void ProcessData(Callback callback)
        {
            callback("3.Processing Completed");
        }

        // Define methods that match the delegate signature
        public static void Method1(string message)
        {
            Console.WriteLine($"2.Method1 : {message}");
        }

        public static void Method2(string message)
        {
            Console.WriteLine($"2.Method2 : {message.ToUpper()}");
        }

        //Delegate Define
        public delegate void MyDelegate(string message);

        //Define the method that Deligates will refer to
        public static void DidYouCallMe(string message)
        {
            Console.WriteLine($"1.Did You Call Me ? {message}");
        }
        public static void Main()
        {
            //Create Deligate Instances and referance Methods
            MyDelegate del1 = new MyDelegate(DidYouCallMe);

            //1.메서드 참조를 변수로 저장
            del1("I called you");

            //2.메서드의 동적 호출
            MyDelegate del2 = Method1;
            del2("Hello");
            del2 = Method2;
            del2("Hello");

            //3.콜백 메서드
            Callback hander = message => Console.WriteLine(message);
            ProcessData(hander);

            //4. 이벤트 처리
            Button button = new Button();
            button.Click += (sender, e) => Console.WriteLine("4.Button clicked");//attaching an event handler
            button.OnClick();//trigger 

            //5.멀티캐스팅
            MultiDelegate del3 = Method3;  // 델리게이트 인스턴스 생성 및 메서드 할당
            del3 += Method4;

            del3();// Invoke the delegate

            //5.멀티캐스팅
            CarDriver goHome = GoForward; // 델리게이트 인스턴스 생성 및 메서드 할당
            goHome += GoLeft;
            goHome += GoRight;
            goHome += GoFast;
            goHome -= GoFast;

            //6. Anonymous Mehtod
            goHome += delegate () { Console.WriteLine("6.Stop"); };
            goHome += delegate { Console.WriteLine("6.Backward"); };
            goHome += () => Console.WriteLine("6.BACKWARD");//Lambda expresion

            goHome();// Invoke the delegate
        }
    }
}

