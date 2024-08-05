using System;

namespace EventTest
{
    //Event Publisher 게시자
    class EventAndDelegateCar
    {
        private int _fuelGauges;

        public int FuleGauge
        {
            get { return _fuelGauges; }
            set
            {
                _fuelGauges = value;
                IlluminateLackOfFuel();
            }
        }
        public EventAndDelegateCar()
        {
            FuleGauge = 25;
        }
        public void Go()
        {
            Console.WriteLine("Drive");
            FuleGauge -= 5;
        }

        //1_Delegate and Event
        /*
                public delegate void FuelEmptyEventHandler();
                public event FuelEmptyEventHandler LackOfFuel;
        */

        //2_Action<T>
        public event Action LackOfFuel;

        public void IlluminateLackOfFuel()
        {
            /*
                        if(LackOfFuel != null)
                        {
                            LackOfFuel();
                        }
            */
            Console.WriteLine($"Status: {FuleGauge} %");

            if (FuleGauge <= 20)
            {
                LackOfFuel?.Invoke();// call if registered
            }
        }
    }
}
