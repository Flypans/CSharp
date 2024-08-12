using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPatternTest
{
    //1.Delegate 정의 (선택 사항)
    public delegate void MyEventHandler(object sender, MyEventArgs args);

    //2.EventArgs 클래스 정의 (선택 사항)
    public class MyEventArgs
    {
        public string Content { get; set; }
    }

    //3.Event Publisher 정의
    public class Publischer
    {
        //3. 이벤트 선언
        public event EventHandler<MyEventArgs> MyCoustomEvent;

        //3. 이벤트 트리거 메서드
        public void TriggerEvent()
        {
            MyCoustomEvent?.Invoke(this, new MyEventArgs { Content = "Event Triggered" });
        }
    }

    //4. Event Subscriber 정의
    public class Subscriber
    {
        //4. 이벤트 메서드에서 구독
        public void Subscribe(Publischer publischer)
        {
            publischer.MyCoustomEvent += HandlerCustomerEvent;
        }

        //4. 이벤트 핸들러 메서드
        private void HandlerCustomerEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine("Event received:" + e.Content);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Publischer publischer = new Publischer();
            Subscriber subscriber = new Subscriber();

            
            subscriber.Subscribe(publischer);

            // Event Trigger
            publischer.TriggerEvent();
        }
    }
}
