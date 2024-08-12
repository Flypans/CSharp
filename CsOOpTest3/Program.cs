using System;
using System.Collections;


namespace CsOOpTest3
{
    interface IStandard { void Run(); }
    class Car : IStandard
    {
        #region Fields
        private string name;
        private string[] names;
        private readonly int _Length;
        #endregion

        #region  Constructors
        public Car()
        {
            this.name = "Mein Auto";
        }
        public Car(string name)
        {
            this.name = name;
        }
        public Car(int length)
        {
            this.Name = "Dein Auto";
            _Length = length; // 읽기전용 필드는 생성자에 의해서 초기화 가능
            names = new string[length]; //넘겨온 값으로 요소생성    
        }
        #endregion


        public void Run()
        {
            Console.WriteLine("{0} fährt ab.", name);
        }

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Length { get { return _Length; } }
        #endregion

        #region Destructor
        ~Car()  
        {
            Console.WriteLine("{0} ist Schrott.", name);
        }
        #endregion

        #region Indexer
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        #endregion

        #region Iterators
        public IEnumerator GetEnumerator() 
        {
            for (int i = 0; i < _Length; i++)
            {
                yield return names[i];
            }
        }
        #endregion

        #region  Delegates
        public delegate void EventHandler(); 
        #endregion

        #region Events
        public event EventHandler Click; // Click Event
        #endregion

        #region Event Handlers
        public void OnClick()
        {
            if (Click != null)
            {
                Click();
            }
        }
        #endregion
    }

    class CsOOpTest3
    {
        static void Main()
        {
            
            Car campingCar = new Car("Camping Auto");
            campingCar.Run();

            Car sportsCar = new Car();
            sportsCar.Name = "Sports Auto";
            sportsCar.Run(); 

            Car cars = new Car(2);
            cars[0] = "erste Auto";
            cars[1] = "zweite Auto";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (string name in cars)
            {
                Console.WriteLine(name);
            }

            Car btn = new Car("E-Wagen");
            btn.Click += new Car.EventHandler(btn.Run);
            btn.Click += new Car.EventHandler(btn.Run);
            btn.OnClick();
        }
    }
}
